﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    public interface Statistic
    {
        void updateSelectedControls(User i_user);
    }
}