﻿/*
//penyemangat
                         ..:..                                                                                                                    
                          7~~~~^:.                                                         .:::                                                   
                         ^7:^^^~~~~:.                                                  .:^~~~~7^                                                  
                         ~7^~~!!777?J?~:                 ......                     .:~~~~^^^^^7                                                  
                         YPPPPGGGGGGGGGY~..    ..:^^~~!!!!!!!!!7!!!!~^^:.        .^~!~^^^^^^^^^7.                                                 
                         PGGGGGGGGGP5?!^~~!~^~~!~~~~^^^^~~~~~^^^^^^^~~!!!!!~:..:~!~^^^^^^^^^^^^7:                                                 
                        .PGGGGGGP5J!~~~~!!77!~^^~~!!!!!7^...:^~~!~^^^^^^^^^~!!7?!!!!!!!~~^^^^^^7^                                                 
                        :PGG5J???7???JJ?~^:^~!7!!~~^^^~! . ~!~^^^^^^~~^^^^^^^^^~!7???7?7?77!~^^!^                                                 
                .        J?!!!!!!7?YJ!::^!77!^^^^^^^^^~! ..!~^^^^^^^^^!~^^^^^^^^^^^~7J?77!!~!!~7:                                                 
      .:^!7JYYY555YJ?!^. ^7^~!!7?JJ~::!77~^^^^^^^^^^^^^7...:!^^^^^^^^^^~~^^^^~~^^^^^:^7JJ7??7~~?.                                                 
    75PPGGGGGGGGGGGGGGG5?~J7JJYPY~.:!7!^^^^^^^^^^^^^^^~!! ..!~^^^^^^^^^^^~^^^~!!~^^^^^::?Y?!~!77.                                                 
    .!PGGGPGGGGGGGGGPGGGGGGGGGG7. ^7~^^^^^^^^^^^^^^^^!~:!~ .:7^^^^^^^^^^^:!^^^^^!!^^^^:  ^JJ?77!                                                  
      .!5GGGGGGGGGGGGGGGGGGGBP^ .!~.:^^^^^^^^^^^^^^^^!:^^!!..:7^^^^^^^^^^:~7^^^!!?!^^^::. .7Y7??                                                  
         ~JPGGGGGGGGGGGGGGGG5::~7~.:^^^^^^^^^!^^^^^^!~.:^^~!^..!~^^^^^^^^^.?!~7J??J!!^:^^^^:~YY~                                                  
           .~?YPPPPGGGGGGGB5::!7:^^^^^^^^^^^~7^^^^^^7^  .^^^!!:.~!~^^^^^^^.~7^~J!7!~77^^^^^^:^Y!~^.                                               
               .~?YGGGGGGGP::7!:^^^^^^^^^^^^!!^^^^^!7!:.:^^^^:!~::!!^^^^^^~!J7^!!~???Y!^^^^^^:^Y~!?:                                              
            :!J5PGGGGGGGPG!:!7:^^^^^^^^^^^^^7~^^~~!7^~:^!~^^^^^^~~^~!~^^^^:~!~7!~7J7??~7^^^^^^:~?:~J:                                             
          .?PGGGGGGGGGGGG5:~?^^^^^^^^^^^^^^~J7~~~^!: !:^J!^^^^^^^~~!!!7!~^:!: .!7!7^^^!JYY7^^^^:?!:~?.                                            
         :5GGGGGGGGGGGGGB!:7~^^^^^^^^^^^^^^!^7:^^^7: :~^77^^^^^^^!^!~^~~77!7..  :~7JJ5PPGGGY^^^^^J^^J^                                            
        .5GGGGGGGGGGGGGYY^~!^^^^^^^^^^^^^^!^ 7^:^:!.  ^~!^7~~^^^^!!?~^^^~!?:.     :?PGGPP5J7^^^^^?!^~7                                            
        JGGGGGGGGGGGG57~J:^^^^^^^^^^^~~^^^77!?J777?^^::~7:^~^:::^777^~~^77^.:^^~~~~~?5Y?!~^^^^^^^7?:^?.                                           
       !GP555GGGGGG57^:!7^~^^^^^^^^^^~!^^^JJJJYPY5P5PGGG5~       :.    .^7PGG5J??????~!^^^^^^^^^^~?^^7^                                           
      ~55PP5YGGG55J^:^:77~!^^^^^^^^^^^?^^^7    !~^JYPPJ!:.  .. .. .. . . .^7Y5Y?~.   .7^^^^~!^^^^^J^^!~                                           
    .?GY5P5YY?!~!~^^^^^J7!!^^^^^^^^~~:!7^^7   :!PGPY^.     ....  .   .....   .^75PY!:.7^^^^?7^^^^^?^^^!                                           
    :~^^^^:.  ~!^^^^^!7J?7~^^^^^^^^^7^^7!:7~!YG57~~!.     ^!!7!!~:.:~!!!!!: .    :!J57?^^^7~~7^^^^7^^^J.                                          
            ^7~^^^^~7?7?Y?^^^^^^^^^^~7^^!!!JP?^....^:... :?~~~~!!!!!!~~!~!? .........?~^^??  J^^^~7^^^J!                                          
          ^!!^^^^~7777??JY^^~~^^^^^^^!7^:~!7~!^......... ^?~!~~!!!!!!7!!!7! ........~7^~7P^ ~7^^^7!^^^7J: .                                       
        :!!^^^^~!!!!77~.~G^^~!^^^^^^^^~?~:~~^^!!~:......  ^!!!!~^:...^~~~^.........~7~!~?5Y7?^^^^Y~^^^777.                                        
      :!!^^^^^^~!!~^.   :P!^^7^^^^^^^^^^?7^~!^^^~!~~^::...  ..   .        ...    .~7~^.!5YYYJ^^^7J^^^^!7^7.                                       
  . :7!^^^^^~7?~:       .57^^7!^^^^^^^^^^7Y77~^^~~~~~~~^^.                       .:.  ?J?Y?YY~^~!?^^^^~?^~7.                                      
  .~!~^^^^!7JY:         .YJ^^~J~^^!^^^^^^^^?YJ7^ .                                  ^J7:555557^^^?^^^^^J~^~?.                                     
 ^7~^^^~77~!J:          .Y?!^^7J^^~7!^^^^^^^^!?J7:..      .                  ..  .^?Y!:^PJYY?J^^~?^^^^^?:!~^J.                                    
~7^^^~J?~^^J~           .J~J^^~?J~^^!!!~^^^^^^^^~!!!~~~~~:                    .:!?JJJ!^^P55P77?:^J^^^^^7! ~~!7                                    

*/

using mod4_1302210095;

internal class Program
{
    private static void Main(string[] args)
    {
        KodeBuah etalase = new KodeBuah();

        Console.WriteLine("daftar buah dan kodenya: ");
        Console.Write(KodeBuah.Buah.Semangka + ": ");
        Console.WriteLine(etalase.getKodeBuah(KodeBuah.Buah.Semangka));
        Console.Write(KodeBuah.Buah.apel + ": ");
        Console.WriteLine(etalase.getKodeBuah(KodeBuah.Buah.apel));
        Console.Write(KodeBuah.Buah.Durian + ": ");
        Console.WriteLine(etalase.getKodeBuah(KodeBuah.Buah.Durian));

        PosisiKarakterGame playerAction = new PosisiKarakterGame();
        playerAction.currentState = PosisiKarakterGame.KarakterState.Berdiri;

        Console.WriteLine("\nProgram menggerakan karakter");
        Console.WriteLine("current player state: " + playerAction.currentState);
        Console.WriteLine();

        playerAction.activeTrigger(PosisiKarakterGame.Trigger.TombolW); //terbang dulu
        playerAction.activeTrigger(PosisiKarakterGame.Trigger.TombolX); //landing dulu
        playerAction.activeTrigger(PosisiKarakterGame.Trigger.TombolW); //berdiri dulu
        playerAction.activeTrigger(PosisiKarakterGame.Trigger.TombolW); //terbang lagi
    }
}