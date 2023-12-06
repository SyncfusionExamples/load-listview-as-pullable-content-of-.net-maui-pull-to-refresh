## Host .NET MAUI ListView as pullable content

To host the .NET MAUI `ListView` inside the `PullToRefresh`, which is used to update items in the list while performing the pull to refresh action.
<ol>
<li>	Add the required assembly references as discussed in the <a href="https://help.syncfusion.com/maui/listview/getting-started">ListView</a> and PullToRefresh</li>
<li>	Import the SfPullToRefresh control and SfListView control namespace as follows.</li>
<br/>

    xmlns:ListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
    xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"

    using Syncfusion.Maui.ListView;
    using Syncfusion.Maui.PullToRefresh;

<br/>
<li>	Define the ListView as PullableContent of the SfPullToRefresh.</li>
<li>	Handle the pull to refresh events for refreshing the data. </li>
<li>	Customize the required properties of ListView and PullToRefresh based on your requirement.</li>
</ol>

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="RefreshableListView.MainPage"
                xmlns:ListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
                xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
                xmlns:local="clr-namespace:RefreshableListView">

        <ContentPage.Behaviors>
            <local:ListViewPullToRefreshBehavior />
        </ContentPage.Behaviors>

        <ContentPage.Content>
            <Grid>
                <pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                            RefreshViewHeight="50"
                                            RefreshViewThreshold="30"
                                            PullingThreshold="150"
                                            RefreshViewWidth="50"
                                            TransitionMode="SlideOnTop"
                                            IsRefreshing="False">
                    <pulltoRefresh:SfPullToRefresh.PullableContent>
                        <Grid x:Name="mainGrid">
                            <ListView:SfListView Grid.Row="1"
                                                x:Name="listView"
                                                ItemsSource="{Binding InboxInfos}"
                                                ItemSize="102"
                                                SelectionMode="Single"
                                                ScrollBarVisibility="Always"
                                                AutoFitMode="Height">
                                . . . 
                                . . . .

                            </ListView:SfListView>
                        </Grid>
                    </pulltoRefresh:SfPullToRefresh.PullableContent>
                </pulltoRefresh:SfPullToRefresh>
            </Grid>
        </ContentPage.Content>
    </ContentPage>

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   N> If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            
            InitializeComponent();
            
            MainPage = new AppShell();
        }

    Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/overview) for more details.

3. Clean and build the application.
4. Run the application.