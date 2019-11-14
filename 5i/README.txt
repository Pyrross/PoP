                                         (              
   (                           (         )\ )    _ _    
   )\           )          (   )\   (   (()/(  _| | |_  
 (((_)   (     (     `  )  )\ ((_) ))\   /(_))|_  .  _| 
 )\___   )\    )\  ' /(/( ((_) _  /((_) (_))_||_     _| 
((/ __| ((_) _((_)) ((_)_\ (_)| |(_))   | |_    |_|_|   
 | (__ / _ \| '  \()| '_ \)| || |/ -_)  | __|           
  \___|\___/|_|_|_| | .__/ |_||_|\___|  |_|             
                    |_|                                          
Benyt Mono-Project til at kompilere .fsx-filen. Dette kan enten gøres ved kommandoen
fsharpi 5i1.fsx     eller ved     fsharpc 5i1.fsx && mono 5i1.exe
 _____     __  ,---.    ,---.  .---.      
 \   _\   /  / |    \  /    |  | ,_|      
 .-./ ). /  '  |  ,  \/  ,  |,-./  )      
 \ '_ .') .'   |  |\_   /|  |\  '_ '`)    
(_ (_) _) '    |  _( )_/ |  | > (_)  )    
  /    \   \   | (_ o _) |  |(  .  .-'    
  `-'`-'    \  |  (_,_)  |  | `-'`-'|___  
 /  /   \    \ |  |      |  |  |        \ 
'--'     '----''--'      '--'  `--------` 
XML-encoding i .fsx-filernes kommentarer kan kompileres ved at benytte Mono-Project.
fsharpc --doc: 5i0.xml 5i0.fsx
Herefter kan .xml-filen åbnes i vilkårligt program, gerne tekstredigeringsprogram.