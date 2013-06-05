﻿using Flowdock.ViewModels;
using MoqaLate.Autogenerated;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowdock.UnitTests.ViewModels {

	public class LoginViewModelTest {
		private AppSettingsMoqaLate _appSettings;
		private LoginViewModel _viewModel;

		[SetUp]
		protected void BeforeEach() {
			_appSettings = new AppSettingsMoqaLate();
			_viewModel = new LoginViewModel(new FlowdockContextMoqaLate(), _appSettings, new NavigationManagerMoqaLate());
		}

		[Test]
		public void Username_should_set_on_settings() {
			string username = "hellokitty";
			_viewModel.Username = username;

			Assert.That(_appSettings.Username, Is.EqualTo(username));
		}

		[Test]
		public void Username_should_fire_property_changed() {
			string propertyName = null;
			_viewModel.PropertyChanged += (o, e) => propertyName = e.PropertyName;

			_viewModel.Username = "hellokitty";

			Assert.That(propertyName, Is.EqualTo("Username"));
		}

		[Test]
		public void Password_should_set_on_settings() {
			string password = "mypassword";
			_viewModel.Password = password;

			Assert.That(_appSettings.Password, Is.EqualTo(password));
		}

		[Test]
		public void Password_should_fire_property_changed() {
			string propertyName = null;
			_viewModel.PropertyChanged += (o, e) => propertyName = e.PropertyName;

			_viewModel.Password = "mypassword";

			Assert.That(propertyName, Is.EqualTo("Password"));
		}
	}
}
