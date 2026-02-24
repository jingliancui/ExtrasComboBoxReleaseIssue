using System;
using System.Collections.ObjectModel;

namespace SampleApp;

public class MainPageViewModel
{
    public MainPageViewModel()
    {
        CountryList = new List<CountryModel>()
        {
            new CountryModel{Name="China"},
            new CountryModel{Name="The UK"},
            new CountryModel{Name="The USA"},
        };
        SelectedCountry=CountryList[0];
    }
    public List<CountryModel> CountryList { get; set; }

    public CountryModel SelectedCountry { get; set; }
}
