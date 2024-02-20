using System.Collections.ObjectModel;
using System.Globalization;

namespace ReusableListView;

public partial class CustomListView : ListView
{
	public CustomListView()
	{
		InitializeComponent();
	}

	static CustomListView()
	{
		PartialTemplateProperty = BindableProperty.Create(nameof(PartialTemplate), typeof(DataTemplate), typeof(CustomListView));
	}

	public static readonly BindableProperty PartialTemplateProperty;

	public DataTemplate PartialTemplate
	{
		get => (DataTemplate)base.GetValue(PartialTemplateProperty);
		set => base.SetValue(PartialTemplateProperty, value);
	}
}