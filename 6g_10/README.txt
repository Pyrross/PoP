                                         (              
   (                           (         )\ )    _ _    
   )\           )          (   )\   (   (()/(  _| | |_  
 (((_)   (     (     `  )  )\ ((_) ))\   /(_))|_  .  _| 
 )\___   )\    )\  ' /(/( ((_) _  /((_) (_))_||_     _| 
((/ __| ((_) _((_)) ((_)_\ (_)| |(_))   | |_    |_|_|   
 | (__ / _ \| '  \()| '_ \)| || |/ -_)  | __|           
  \___|\___/|_|_|_| | .__/ |_||_|\___|  |_|             
                    |_|                                          
Benyt Mono-Project til at kompilere .fs-filen til .fsi (signatur) samt lave en
eksekverbar fil gennem fsharpc -a continuedFraction.fs
Benyt Mono-Project til at kompilere .fsx-filen. Dette kan enten gøres ved kommandoen
fsharpc -r continuedFraction.dll 6g4.fsx && mono 6g4.exe
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
fsharpc --doc: continuedFraction.xml continuedFraction.fs
Herefter kan .xml-filen åbnes i vilkårligt program, gerne tekstredigeringsprogram.