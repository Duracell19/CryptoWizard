﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro;
using CryptoWizard.Views;
using CryptoWizard.ViewModels;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace CryptoWizard
{
  public sealed partial class App
  {
    private WinRTContainer _container;

    public App()
    {
      this.InitializeComponent();
      this.Suspending += OnSuspending;
    }

    protected override void Configure()
    {
      _container = new WinRTContainer();
      _container.RegisterWinRTServices();
      _container.PerRequest<MainPageViewModel>();
      _container.PerRequest<AdditionViewModel>();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs e)
    {
      var navigationManager = SystemNavigationManager.GetForCurrentView();
      navigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

#if DEBUG
      if (Debugger.IsAttached)
      {
        this.DebugSettings.EnableFrameRateCounter = false;
      }
#endif
      DisplayRootView<MainPageView>();

      SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
    }

    protected override void OnSuspending(object sender, SuspendingEventArgs e)
    {
      var deferral = e.SuspendingOperation.GetDeferral();
      deferral.Complete();
    }

    protected override void PrepareViewFirst(Frame rootFrame)
    {
      _container.RegisterNavigationService(rootFrame);
    }

    protected override object GetInstance(Type service, string key)
    {
      return _container.GetInstance(service, key);
    }

    protected override IEnumerable<object> GetAllInstances(Type service)
    {
      return _container.GetAllInstances(service);
    }

    protected override void BuildUp(object instance)
    {
      _container.BuildUp(instance);
    }

    private void OnBackRequested(object sender, BackRequestedEventArgs e)
    {
      Frame rootFrame = Window.Current.Content as Frame;

      if (rootFrame.CanGoBack)
      {
        e.Handled = true;
        rootFrame.GoBack();
      }
    }
  }
}
