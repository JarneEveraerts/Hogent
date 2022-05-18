using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportCarApp;

SportStyle sportStyle = new();
EconomyStyle economyStyle = new();

Auto auto = new(sportStyle);

auto.Drive();

auto.Style = economyStyle;

auto.Drive();