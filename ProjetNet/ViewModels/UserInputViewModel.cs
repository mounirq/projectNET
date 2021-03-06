﻿using PricingLibrary.FinancialProducts;
using Prism.Mvvm;
using ProjetNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNet.ViewModels
{
    internal class UserInputViewModel : BindableBase
    {
        #region Private Fields

        private UserInput underlyingUserInput;

        private String optionType;
        private DateTime startDate = DateTime.Today;
        private DateTime maturity = DateTime.Today;
        private double strike;
        private List<string> underlyingsIds = new List<string>();
        private List<double> weights = new List<double>();
        private AbstractDataProviderViewModel dataType;
        private int estimationWindow;
        private int rebalancementFrequency;
        private String nameOption;

        #endregion Private Fields

        #region Public Constructors

        public UserInputViewModel()
        {
            this.underlyingUserInput = new UserInput();
        }

        #endregion Public Constructors

        #region Public Properties

        public UserInput UnderlyingUserInput
        {
            get { return this.underlyingUserInput; }
            set { SetProperty(ref this.underlyingUserInput, value); }

        }

        public String OptionType
        {
            get { return this.optionType; }
            set
            {
                SetProperty(ref this.optionType, value);
                UnderlyingUserInput.OptionType = value;
            }
        }

        public DateTime Maturity
        {
            get { return this.maturity; }
            set
            {
                SetProperty(ref this.maturity, value);
                UnderlyingUserInput.Maturity = value;
            }
        }

        public Double Strike
        {
            get { return this.strike; }
            set
            {
                SetProperty(ref this.strike, value);
                UnderlyingUserInput.Strike = value;
            }
        }

        public List<string> UnderlyingsIds
        {
            get { return this.underlyingsIds; }
            set
            {
                SetProperty(ref this.underlyingsIds, value);
                UnderlyingUserInput.UnderlyingsIds = value.ToArray();
            }
        }

        public List<double> Weights
        {
            get { return this.weights; }
            set
            {
                SetProperty(ref this.weights, value);
                UnderlyingUserInput.Weights = value.ToArray();
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                SetProperty(ref this.startDate, value);
                UnderlyingUserInput.StartDate = value;
            }
        }

        public AbstractDataProviderViewModel DataType
        {
            get { return this.dataType; }
            set
            {
                SetProperty(ref this.dataType, value);
                UnderlyingUserInput.DataType = value.Data;
            }
        }

        public int EstimationWindow
        {
            get { return this.underlyingUserInput.EstimationWindow; }
            set
            {
                SetProperty(ref this.estimationWindow, value);
                UnderlyingUserInput.EstimationWindow = value;
            }
        }

        public int RebalancementFrequency
        {
            get { return this.underlyingUserInput.RebalancementFrequency; }
            set
            {
                SetProperty(ref this.rebalancementFrequency, value);
                UnderlyingUserInput.RebalancementFrequency = value;
            }
        }

        public String NameOption
        {
            get { return this.nameOption; }
            set
            {
                SetProperty(ref this.nameOption, value);
                UnderlyingUserInput.NameOption = value;
            }
        }

        #endregion Public Properties

        #region Public Methods
        public void AddWeight(double weight)
        {
            if (weight <= 0)
            {
                throw new ArgumentException("The weight must be positive");
            }
            Weights.Add(weight);
            UnderlyingUserInput.Weights = Weights.ToArray();
        }

        public void AddUnderlying(string underlyingId)
        {
            UnderlyingsIds.Add(underlyingId);
            UnderlyingUserInput.UnderlyingsIds = UnderlyingsIds.ToArray();
        }

        public void ClearWeight()
        {
            Weights.Clear();
            UnderlyingUserInput.Weights = Weights.ToArray();
        }

        public void ClearUnderlyings()
        {
            UnderlyingsIds.Clear();
            UnderlyingUserInput.UnderlyingsIds = UnderlyingsIds.ToArray();
        }

        #endregion Public Methods

    }
}
