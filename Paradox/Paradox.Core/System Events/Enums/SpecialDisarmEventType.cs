﻿/*
 *	 Paradox .NET library
 *	 Web site: http://sebastien.warin.fr
 *	 Copyright (C) 2014-2017 - Sebastien Warin <http://sebastien.warin.fr>	   	  
 *	
 *	 Licensed to Sebastien Warin under one or more contributor
 *	 license agreements. Sebastien Warin licenses this file to you under
 *	 the Apache License, Version 2.0 (the "License"); you may
 *	 not use this file except in compliance with the License.
 *	 You may obtain a copy of the License at
 *	
 *	 http://www.apache.org/licenses/LICENSE-2.0
 *	
 *	 Unless required by applicable law or agreed to in writing,
 *	 software distributed under the License is distributed on an
 *	 "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 *	 KIND, either express or implied. See the License for the
 *	 specific language governing permissions and limitations
 *	 under the License.
 */

namespace Paradox.Events
{
    /// <summary>
    /// Special disarm type
    /// </summary>
    public enum SpecialDisarmEventType
    {
        AutoArmCancelled = 0,
        OneTouchStayOrInstantDisarm = 1,
        DisarmingWithWinLoad = 2,
        DisarmingWithWinLoadAfterAlarm = 3,
        WinLoadCancelledAlarm = 4,
        //FutureUse=5,
        //FutureUse=6,
        //FutureUse=7,
        InTouchVoiceModuleDisarming = 8
    }
}