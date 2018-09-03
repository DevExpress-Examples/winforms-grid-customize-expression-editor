using DevExpress.Data.Controls.ExpressionEditor;
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.DataAccess.ExpressionEditor;
using DevExpress.DataAccess.UI.ExpressionEditor;
using DevExpress.DataAccess.UI.Native.ExpressionEditor;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1 {
    public partial class Form1 : XtraForm {
        public class Product {
            public Product(int productID, string productName, Category category) {
                ProductID = productID;
                ProductName = productName;
                Category = category;
            }

            public int ProductID { get; }
            public string ProductName { get; }
            public int? SupplierID { get; set; }
            public int? CategoryID { get; set; }
            public short? UnitsOnOrder { get; set; }
            public bool Discontinued { get; set; }
            public Category Category { get; }
        }

        public class Category {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }

        static List<Product> GetProductsList() {
            var categoryBeverages = new Category { CategoryID = 1, CategoryName = "Beverages" };
            var categoryConfections = new Category { CategoryID = 2, CategoryName = "Condiments" };
            return new List<Product> {
                new Product(1, "Chai", categoryBeverages),
                new Product(2, "Chang", categoryBeverages),
                new Product(3, "Coffee", categoryBeverages),
                new Product(4, "Chocolade", categoryConfections),
                new Product(5, "Maxilaku", categoryConfections),
                new Product(6, "Valkoinen suklaa", categoryConfections),
            };
        }

        public Form1() {
            InitializeComponent();
            this.gridControl1.DataSource = GetProductsList();
        }

        void gridView1_UnboundExpressionEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.UnboundExpressionEditorEventArgs e) {
            if(e.ExpressionEditorContext == null) {
                return;
            }

            // Exclude "Now" from the list of available functions.
            var nowFunction = e.ExpressionEditorContext.Functions.FirstOrDefault(fi => string.Equals(fi.Name, "now", StringComparison.OrdinalIgnoreCase));
            if(nowFunction != null) {
                e.ExpressionEditorContext.Functions.Remove(nowFunction);
            }

            // Uncomment the following line to use a custom color provider.
            //e.ExpressionEditorContext.ColorProvider = new CustomColorProvider();

            // Implement a custom criteria validator (e.g., to forbid using a specific function).
            e.ExpressionEditorContext.CriteriaOperatorValidatorProvider = new ValidatorProvider();

            // Disable capitalization of function names in expressions.
            e.ExpressionEditorContext.OptionsBehavior.CapitalizeFunctionNames = false;

            // Rename the "Columns" category to "Fields".
            foreach(var columnInfo in e.ExpressionEditorContext.Columns) {
                columnInfo.Category = "Fields";
            }

            // Uncomment the following line to use a custom Expression Editor view.
            //e.ExpressionEditorView = new CustomExpressionEditorView(this.LookAndFeel, new CustomExpressionEditorControl());
        }
    }

    class ValidatorProvider : ICriteriaOperatorValidatorProvider {
        #region Implementation of ICriteriaOperatorValidatorProvider

        public ErrorsEvaluatorCriteriaValidator GetCriteriaOperatorValidator(ExpressionEditorContext context) {
            return new Validator(context);
        }

        #endregion
    }

    class Validator : CriteriaOperatorValidator {
        public Validator(ExpressionEditorContext context)
            : base(context, supportsAggregates: true) {
        }

        #region Overrides of CriteriaOperatorValidator

        public override void Visit(FunctionOperator theOperator) {
            if (theOperator.OperatorType == FunctionOperatorType.Now) {
                this.errors.Add(new CriteriaValidatorError("Invalid function: now()"));
            }
            base.Visit(theOperator);
        }

        #endregion
    }


    class CustomColorProvider : IExpressionEditorColorProvider {
        public Color GetColorForElement(ExpressionElementKind elementKind) {
            if (elementKind == ExpressionElementKind.Column)
                return Color.BlueViolet;

            if (elementKind == ExpressionElementKind.Function)
                return Color.Brown;

            return Color.Azure;
        }
    }

    public class CustomExpressionEditorView : ExpressionEditorView {
        public CustomExpressionEditorView(UserLookAndFeel lookAndFeel, ExpressionEditorControl expressionEditor)
            : base(lookAndFeel, expressionEditor) {
        }
    }

    public class CustomExpressionEditorControl : ExpressionEditorControl {
        #region Overrides of ExpressionEditorControl

        protected override ExpressionDocumentationControl CreateDocumentationControl() {
            return null;
        }

        #endregion
    }

}
