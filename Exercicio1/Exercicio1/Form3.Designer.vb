<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultasDataSet = New Exercicio1.ConsultasDataSet()
        Me.MedicoDestritoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicoDestritoTableAdapter = New Exercicio1.ConsultasDataSetTableAdapters.MedicoDestritoTableAdapter()
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoDestritoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MedicoDestritoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Exercicio1.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(600, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsultasDataSet
        '
        Me.ConsultasDataSet.DataSetName = "ConsultasDataSet"
        Me.ConsultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicoDestritoBindingSource
        '
        Me.MedicoDestritoBindingSource.DataMember = "MedicoDestrito"
        Me.MedicoDestritoBindingSource.DataSource = Me.ConsultasDataSet
        '
        'MedicoDestritoTableAdapter
        '
        Me.MedicoDestritoTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoDestritoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MedicoDestritoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultasDataSet As Exercicio1.ConsultasDataSet
    Friend WithEvents MedicoDestritoTableAdapter As Exercicio1.ConsultasDataSetTableAdapters.MedicoDestritoTableAdapter
End Class
