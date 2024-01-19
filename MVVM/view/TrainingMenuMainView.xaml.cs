using dumbbell_app.MVVM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.AccessControl;
using System.Data;

namespace dumbbell_app.MVVM.view
{
    /// <summary>
    /// Interaction logic for TrainingMenuMainView.xaml
    /// </summary>
    public partial class TrainingMenuMainView : UserControl
    {
        public class Train
        {
            public string TrainingName { get; set; }
            public int TrainingCount { get; set; }
            public string TrainingMemo { get; set; }
            public string TrainingTime { get; set; }
            public string TrainingType { get; set; }
        }
        public TrainingMenuMainView()
        {
            InitializeComponent();
           
        }

        void fillDataGrid()
        {   
            // Declare data grid table model
            DataTable dt = new DataTable();
            // Declare column header
            DataColumn TrainingName = new DataColumn("trainingName",typeof(string));
            DataColumn TrainingNumber = new DataColumn("trainingNumber", typeof(int));
            DataColumn TrainingMemo = new DataColumn("trainingMemo", typeof(string));
            DataColumn TrainingTime = new DataColumn("trainingTime", typeof(int));
            DataColumn TrainingType = new DataColumn("trainingType", typeof(string));
            // Insert column header
            dt.Columns.Add(TrainingName);
            dt.Columns.Add(TrainingNumber);
            dt.Columns.Add(TrainingMemo);
            dt.Columns.Add(TrainingTime);
            dt.Columns.Add(TrainingType);
            // Loop gernerate data
            for (int i = 0; i < 10; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow[0] = "abc";
                dataRow[1] = i;
                dataRow[2] = "def";
                dataRow[3] = i*10;
                dataRow[4] = "zxy";

                dt.Rows.Add(dataRow);
            }
            // Binding data grid model to component
            TrainMenuTable.ItemsSource = dt.DefaultView;
            // Binding max row index
            TrainMenuTable.AlternationCount = dt.Rows.Count;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.fillDataGrid();
        }
    }
}
