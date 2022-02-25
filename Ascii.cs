using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_TxT
{
    class Ascii
    {
        public string titre = @"                               __    ___  ___           _____       _____ 
                              /__\  / _ \/ _ \         /__   \__  _/__   \
                             / \// / /_)/ /_\/  _____    / /\/\ \/ / / /\/
                            / _  \/ ___/ /_\\  |_____|  / /    >  < / /   
                            \/ \_/\/   \____/           \/    /_/\_\\/  By Akinelo  
                                              ";

        string titreFin = @"
 ▄▄▄▄    ▒█████   ███▄    █  ███▄    █ ▓█████     ▄▄▄██▀▀▀▒█████   █    ██  ██▀███   ███▄    █ ▓█████ ▓█████ 
▓█████▄ ▒██▒  ██▒ ██ ▀█   █  ██ ▀█   █ ▓█   ▀       ▒██  ▒██▒  ██▒ ██  ▓██▒▓██ ▒ ██▒ ██ ▀█   █ ▓█   ▀ ▓█   ▀ 
▒██▒ ▄██▒██░  ██▒▓██  ▀█ ██▒▓██  ▀█ ██▒▒███         ░██  ▒██░  ██▒▓██  ▒██░▓██ ░▄█ ▒▓██  ▀█ ██▒▒███   ▒███   
▒██░█▀  ▒██   ██░▓██▒  ▐▌██▒▓██▒  ▐▌██▒▒▓█  ▄    ▓██▄██▓ ▒██   ██░▓▓█  ░██░▒██▀▀█▄  ▓██▒  ▐▌██▒▒▓█  ▄ ▒▓█  ▄ 
░▓█  ▀█▓░ ████▓▒░▒██░   ▓██░▒██░   ▓██░░▒████▒    ▓███▒  ░ ████▓▒░▒▒█████▓ ░██▓ ▒██▒▒██░   ▓██░░▒████▒░▒████▒
░▒▓███▀▒░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░ ▒░   ▒ ▒ ░░ ▒░ ░    ▒▓▒▒░  ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░ ▒░   ▒ ▒ ░░ ▒░ ░░░ ▒░ ░
▒░▒   ░   ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░░   ░ ▒░ ░ ░  ░    ▒ ░▒░    ░ ▒ ▒░ ░░▒░ ░ ░   ░▒ ░ ▒░░ ░░   ░ ▒░ ░ ░  ░ ░ ░  ░
 ░    ░ ░ ░ ░ ▒     ░   ░ ░    ░   ░ ░    ░       ░ ░ ░  ░ ░ ░ ▒   ░░░ ░ ░   ░░   ░    ░   ░ ░    ░      ░   
 ░          ░ ░           ░          ░    ░  ░    ░   ░      ░ ░     ░        ░              ░    ░  ░   ░  ░
      ░                                                                                                      ";


        //  Test Animation Beg
        string beg1 = @"
      _   
	\((}/ 
	 ) '  
	,` )  
	 ¯¯ 
";
        string beg2 = @"
       _  
	 |´(}/
	 / .´ 
	,` )  
	 ¯¯
";
        string beg3 = @"
        _  
	 ,-´/}_
	,' ,¯¯ 
	 ¯¯
";
        string beg4 = @"
    _ 
	,-'¯´_)
	 ¯¯¯ ¯¯
";
        public string GetBeg1()
        {
            return beg1;
        }
        public string GetBeg2()
        {
            return beg2;
        }
        public string GetBeg3()
        {
            return beg3;
        }
        public string GetBeg4()
        {
            return beg4;
        }















        public string GetTitre()
        {
            return titre;
        }
        public string GetTitreFin()
        {
            return titreFin;
        }
    }
}
