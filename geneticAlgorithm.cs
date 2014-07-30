using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication1
{
    class GeneticAlg
    {

        public static void Main(String[] args)
        {
            

            //ERWTHSH GIA TO P (ari8mos dianismatwn)
            Console.WriteLine("dwse zigo ari8mo P");

        //!!!!!DHMIOURGIA ARXIKWN DIANISMATWN !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            int P = Convert.ToInt32(Console.ReadLine());

            int[,] pli8ismos = new int[P, 77];
            int[] epi8imito = new int[77] { 1, 0, 0, 0, 0, 1, 0,
                                            1, 0, 0, 0, 1, 0, 0,
                                            1, 0, 0, 1, 0, 0, 0, 
                                            1, 0, 1, 0, 0, 0, 0,
                                            1, 1, 0, 0, 0, 0, 0, 
                                            1, 0, 0, 0, 0, 0, 0,
                                            1, 1, 0, 0, 0, 0, 0, 
                                            1, 0, 1, 0, 0, 0, 0, 
                                            1, 0, 0, 1, 0, 0, 0, 
                                            1, 0, 0, 0, 1, 0, 0, 
                                            1, 0, 0, 0, 0, 1, 0 };
            int[] voi8itikos = new int[P];
            int[,] temp = new int[P, 77];
            int[,] zevgarwma = new int[P, 77];

            for (int i = 0; i < P; i++)
            {
             voi8itikos[i] = i;//voi8itikos pinakas pou 8a dextei thn ari8mhsh tou sorting
            }


            //MHDENISMOS TOU  VASIKOU PINAKA!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            for (int i = 0; i < P; i++)
            {
                for (int j = 0; j < 77; j++)
                {
                    pli8ismos[i, j] = 0;
                }
            }

        //VAZOUME 21 ASSOUS SE RANDOM 8ESEIS MESA STON PINAKA!!!!!!!!!!!!!!!!!


            for (int i = 0; i < P; i++)     //gia ka8e ena apo ola ta dianismata
            {     
                int assoi = 0;
                do
                {
                    Random random = new Random();
                    int x = Convert.ToInt32(random.Next(0, 77));    //ftiaxe mia random topo8esia sto sigekrimeno dianisma

                    if (pli8ismos[i, x] != 1)          //an ekei den iparxei assos  
                    {
                        pli8ismos[i, x] = 1;  //vale ton asso se afth th random 8esh
                        assoi = assoi + 1;   //avxhse tous assous kata 1
                    }
                } while (assoi < 21); //8a to epanalavei mexri na dhmiourgh8oun 22 assoi
            }

    //!!!!!!!!!!!!!!!VA8MOLOGIA PLI8ISMOU (KATALLHLOTHTA) !!!!!!!!!!!!!!!!!!!!

            
                int[] katallhlothta = new int[P];

                for (int i = 0; i < P; i++)
                {
                    katallhlothta[i] = 0;
                    for (int j = 0; j < 77; j++)
                    {
                        if (pli8ismos[i, j] == epi8imito[j] && epi8imito[j] == 1)
                            katallhlothta[i] = katallhlothta[i] + 1;

                    }
                }

          //ELEGXOS MHPWS KAI VRHKAME TO ZHTOUMENO DIANISMA MESW TIXHS!!!!!!!!!!!!


            int epilegomenos=-1;
            for (int i = 0; i < P; i++)
            {
                if (katallhlothta[i] == 21)  //psaxe na vreis an iparxei dianisma pou 
                {                           //einai idio me to apotelesma pou 8eloume
                    epilegomenos = i;
                }
            }
            
            if (epilegomenos!=-1)                          //an iparxei
            {
                Console.WriteLine("To apotelesma einai:");
                for (int j=0;j<77;j++)
                {                                                      //ektipwse to
                    Console.WriteLine(pli8ismos[epilegomenos,j]);
                }
            }
            else                                                 //alliws



  //!!!!!!!!!!!!!!!!!!!!!!!!!H GENIKH EPANALHPSH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


     {       //h epanalhpsh arxizei apo edw me ton ekastote pinaka pli8ismos[P,77]
            while (epilegomenos==-1)                  // trexe ton gnetiko algori8mo
            {                                                  //mexri na to vreis!  


//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                

   //!!!!!!!!!!!!!!!SORTING ANALOGA ME KATALLHLOTHTA!!!!!!!!!!!!!!!!!!!!!!!!!!


                Array.Sort(katallhlothta, voi8itikos); //TWRA o voi8itikos periexei thn kainouria diataxh twn stoixeiwn
                for (int i = 0; i < P; i++)
                {
                    for (int j = 0; j < 77; j++)
                    {
                        temp[i, j] = pli8ismos[voi8itikos[i], j];
                    }
                }


     //!!!!!!!!!!!!!!!!!!!!!!!!IPOLOGISMOS PI8ANOTHTWN!!!!!!!!!!!!!!!!!!!!!!!!!!!!



                int katallhlothtasum = 0;            //a8roisma katallhlothtwn
                for (int i = 0; i < P; i++)
                {
                    katallhlothtasum += katallhlothta[i];

                }

                double[] pi8anothta = new double[P];      //pinakas pi8anothtwn

                for (int i = 0; i < P; i++)
                {
                    pi8anothta[i] = (double)katallhlothta[i] / katallhlothtasum;
                }



    //!!!!!!!!!!!!!!!!!!!!!!!!!!!EPILOGH GONEWN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


                //arxizei h epilogh vasei pi9anothtwn

                Random r = new Random();
                Random r1 = new Random();
                
                int epilegomenos1 = 0;
                int epilegomenos2 = 0;

                for (int m = 0; m < P; m += 2)  //giati 8a ftiaxei ta misa zevgaria
                {
                    
                    double tixh = r.NextDouble();
                    double tixh2 = r1.NextDouble();        //gia olo ton pinaka
                   
                    //ana 2 zevgaria               
                    double a8roistiko = 0;

                    for (int i = 0; i < P; i++)  //exetase poio exei thn megaliterh pi8anothta
                    {


                        a8roistiko = a8roistiko + pi8anothta[i];
                        if (tixh <= a8roistiko)          //epelexe ton prwto gonea
                        {
                            epilegomenos1 = i;
                            break;
                        }

                    }
                    
                    //twra epelexe to devtero megalitero se pi8anothta
                    a8roistiko = 0;
                    for (int i = 0; i < P; i++)
                    {
                        a8roistiko= a8roistiko + pi8anothta[i];

                        if (tixh2 <= a8roistiko && i != epilegomenos1)     //epelexe ton devtero gonea an den einai o idios me ton prohgoumeno
                        {
                            epilegomenos2 = i;
                            break;
                        }
                    }


                    for (int i = 0; i < 77; i++)
                    {
                        zevgarwma[m, i] = temp[epilegomenos1, i];      // kai vale tous sth dexamenh zevgarwmatos
                        zevgarwma[m + 1, i] = temp[epilegomenos2, i];
                    }




                }   //kai avto kane to gia olo ton pinaka ana 2

                //opote twra gemisame thn dexamenh mas

               

 //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!DHMIOURGIA APOGONWN!!!!!!!!!!!!!!!!!!!!!!!!!!!

                int temp1;

                for (int i = 0; i < P-1; i+=2)            //gia ola ta dianismata sth dexamenh zevgarwmatos
                {
                    for (int j = 30; j < 77; j++)
                    {
                        temp1 = zevgarwma[i, j];
                        zevgarwma[i, j] = zevgarwma[i + 1, j];     //kane diastavrwsh 1 shmeiou
                        zevgarwma[i + 1, j] = temp1;
                    }
                         
                        
                    }
                Random randomm = new Random();
                 
                for (int i = 0; i < P; i++)
                {
                    int x = Convert.ToInt32(randomm.Next(0, 77));
                  if (zevgarwma[i,x]==0)
                  {
                      zevgarwma[i,x]=1;
                  }       //!!!!!!!!!!!!!!!!!!!!!!!!!MUTATIOOOOOOONN!!!!!!!!!!!!!!
                  else
                  {
                      zevgarwma[i,x]=0;
                  }

                    }
                
              

                for (int i = 0; i < P; i++)
                {
                    for (int j = 0; j < 77; j++)
                    {
                        pli8ismos[i, j] = zevgarwma[i, j];            //metefere ton kainourio pli8ismo
                        //ston pinaka pli8ismos
                    }
                }

                //!!!!!!!!!!!!!!!KATALLHLOTHTA NEOU PLI8ISMOU!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                for (int i = 0; i < P; i++)
                {
                    katallhlothta[i] = 0;
                    for (int j = 0; j < 77; j++)
                    {
                        if (pli8ismos[i, j] == epi8imito[j] && epi8imito[j] == 1)
                            katallhlothta[i] = katallhlothta[i] + 1;

                    }
                }

                

                //!!!!!!!!!!!!SIN8IKH GIA GENIKH EPANALHPSH!!!!!!!!!!!!!!!!!
               


                for (int i = 0; i < P; i++)
                {
                    if (katallhlothta[i] == 21)      //psaxe na vreis an iparxei dianisma pou 
                    {                                //einai idio me to apotelesma pou 8eloume
                        epilegomenos = i;
                    }
                }

                if (epilegomenos != -1)                          //an iparxei
                {
                    Console.WriteLine("To apotelesma einai:");
                    for (int j = 0; j < 77; j++)
                    {                                                      //ektipwse to
                        Console.Write(pli8ismos[epilegomenos, j]);

                    }
                    Console.WriteLine("avto htan to dianisma");
                    Console.ReadLine();
                }


              


            }    //EDW TELEIWNEI H GENIKH EPANALHPSH 
        }  }                                    
    }
    }
