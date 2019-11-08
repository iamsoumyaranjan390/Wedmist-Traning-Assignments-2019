using System;
namespace Assignment
{
    class Program
    {
        public static void Smallestelementinarray()
        {
            int i       = 0;
			int small   = 0;
			Console.WriteLine("Enter the number of element you want to insert: ");
            int size=int.Parse(Console.ReadLine());
			int[] arr   = new int[size];

			Console.WriteLine("Enter array elements : ");
			
			for (i = 0; i < arr.Length; i++)
			{
				Console.Write("Element[" + (i + 1) + "]: ");
				arr[i] = int.Parse(Console.ReadLine());
			}

			
			small = arr[0];

			for (i = 1; i < arr.Length; i++)
			{
				
				if (small > arr[i])
					small = arr[i];
			}

			
			Console.WriteLine("Smallest element in array is : " + small);
        }
        public static  void Largestelementinarray()
        {
            int i       = 0;
            int large   = 0;
			Console.WriteLine("Enter the number of element you want to insert: ");
            int size=int.Parse(Console.ReadLine());
            int[] arr   = new int[5];
			
			 
            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            
			large = arr[0];
			
            for (i = 1; i < arr.Length; i++)
            {
				
                if (large < arr[i])
                    large = arr[i];
            }
			
            Console.WriteLine("Largest element in array : " + large);
        }
        public static void Totalevennumberinarray()
        {
            Console.WriteLine("Enter the number of element you want to insert: ");
            int size=int.Parse(Console.ReadLine());
             int[] arr = new int[size];
            int i, num, evennum, oddnum;
 
        
        
            Console.WriteLine("Enter "+size+" elements in the array: ");  
 
            for(i=0; i<size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());            
            }
 
            evennum = 0; 
        
 
            for (i = 0; i < size; i++)
            {
            
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
           
            }
            if(evennum>=1)
            {
                Console.WriteLine("Total even  numbers: "+evennum);
            }
             else
            {
                Console.WriteLine("There is no Even numbers in this Array.");
            }
 
 
        
        }
        public static void Totaloccurenceofelement()
        {
             int i       = 0 ;
            int count   = 0 ;
            int item    = 0 ;
            Console.WriteLine("Enter the number of element you want to insert: ");
            int size=int.Parse(Console.ReadLine());
            int[] arr1   = new int[size];
                        
            
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < size; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter item of which you want to check the number of occurences: ");
            item = int.Parse(Console.ReadLine());

            for (i = 0; i < size; i++)
            {
                if (item == arr1[i])
                {
                    count++;
                }
            }

            Console.WriteLine("Total occurrence of item "+item + " is : "+count);
            
            
        }
        public static void Checkpallindrome()
        {
            int n,r,sum=0,temp;    
          Console.Write("Enter the Number: ");   
          n = int.Parse(Console.ReadLine());  
          temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }      
          if(temp==sum)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");  
        }
        public static void Mergetwoarrays()
        {
            int[] arr1 = new int[100];
	        int[] arr2 = new int[100];
	        int[] arr3 = new int[200];
            int size1, size2, size3;
            int i, j, k;
	
	
            Console.Write("\n\nMerging of two arrays of same size sorted in ascending order.\n");
            Console.Write("------------------------------------------------------------\n");	
	   
            Console.Write("Input the number of elements to be stored in the first array :");
	        size1 = Convert.ToInt32(Console.ReadLine()); 	   
   
            Console.Write("Input {0} elements in the array :\n",size1);
            for(i=0;i<size1;i++)
            {
	             Console.Write("element - {0} : ",i);
	             arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	        }


            Console.Write("Input the number of elements to be stored in the second array :");
	        size2 = Convert.ToInt32(Console.ReadLine()); 	   
   
            Console.Write("Input {0} elements in the array :\n",size2);
            for(i=0;i<size2;i++)
            {
	             Console.Write("element - {0} : ",i);
	             arr2[i] = Convert.ToInt32(Console.ReadLine()); 		  
	        }

    
            size3 = size1 + size2;
     
/*----------------- insert in the third array------------------------------------*/
             for(i=0;i<size1; i++)
            {
                arr3[i] = arr1[i];
            }
            for(j=0;j<size2; j++)
            {
                 arr3[i] = arr2[j];
                 i++; 
            }
/*----------------- sort the array in ascending order ---------------------------*/
             for(i=0;i<size3; i++)
             {
                for(k=0;k<size3-1;k++)
                {
         
                     if(arr3[k]>=arr3[k+1])
                     {
                       j=arr3[k+1];
                       arr3[k+1]=arr3[k];
                       arr3[k]=j;
                     }  
                }
             }                      
/*--------------- Prints the merged array ------------------------------------*/
            Console.Write("\nThe merged array in ascending order is :\n");
            for(i=0; i<size3; i++)
            {
                 Console.Write("{0} ", arr3[i]);
            }
	        
        }
        public static void Sumofmatrices()
        {
             int m, n,i,j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
 
            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            int[,] C = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");
 
                }
                
            }
            
        }
        public static void Multiplicationofmatrix()
        {
             int i, j,m,n;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] b = new int[m, n];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                
            }
 
            
        }
        public static void Transposeofmatrix()
        {
            int m, n, i, j;
            Console.Write("Enter the Order of the Matrix : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Matrix : ");
 
           for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[j, i] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        public static int BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }
        public static void BinarySearch()
        {
             Console.WriteLine("Enter the number of elements you want to insert in the array:");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter the elements in sorted order:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the number you want to search in the Array : ");
            int searchNum = Convert.ToInt32(Console.ReadLine());

            int position = BinarySearchDisplay(arr, searchNum);

            if (position == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Found at position Number : {0}",position);
        }
     


        public static int Insertionsort()
        {
              
            Console.Write("\n\nEnter number of elements: ");  
            int size = Convert.ToInt32(Console.ReadLine());  
            int[] array = new int[size];  
            for (int i = 0; i < size; i++)  
            {  
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");  
                array[i] = Convert.ToInt32(Console.ReadLine());  
            }  
            Console.Write("Input int array  : ");  
            for (int k = 0; k < size; k++)  
                Console.Write(array[k] + " ");  
            Console.Write("\n");  
            for (int i = 1; i < size; i++)  
            {  
                int j = i;  
                while (j > 0)  
                {  
                    if (array[j - 1] > array[j])  
                    {  
                        int temp = array[j - 1];  
                        array[j - 1] = array[j];  
                        array[j] = temp;  
                        j--;  
                    }  
                    else  
                        break;  
                }  
                Console.Write("Iteration " + i.ToString() + ": ");  
                for (int k = 0; k < size; k++)  
                    Console.Write(array[k] + " ");  
                Console.Write("\n");  
                //Console.Write("/*** " + (i + 1).ToString() + " numbers from the begining of the array are input and they are sorted ***/\n");    
            }  
            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");  
            for (int i = 0; i < size; i++)  
            {  
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");  
                Console.Write(array[i]);  
                Console.Write("\n");  
            }  
            return 0;  
        }
        public static void SelectionSort()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting :");
             for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            int temp, smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("\nAfter Sorting :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }
        public static void BubbleSort()
        {
             Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting :");
             for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ",arr[i]);
            }


            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int k = 0; k <= arr.Length - 2; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        int temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }

            Console.WriteLine("\nAfter Sorting :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ",arr[i]);
            }
        }

        
        
    
        
        
    
         static void Main(string[] args)
        {
            int choice;
            String inputChoice;
            Console.WriteLine("-------------part-2 of assignment containing 13 Questions Submitted by Soumya Ranjan Mohanty---------------- \n");
            Console.Write("enter the serial number of question that you want to execute (press 0 to exit): ");
            inputChoice= Console.ReadLine();
            Console.WriteLine();
            choice = Convert.ToInt32(inputChoice);
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        
                         Smallestelementinarray();
                        break;
                    case 2:
                        Largestelementinarray();

                        break;
                    case 3:
                        Totalevennumberinarray();
                        break;
                    case 4:
                        Totaloccurenceofelement();
                        break;
                    case 5:
                        Checkpallindrome();
                        break;
                    case 6:
                         Mergetwoarrays();
                        break;
                    case 7:
                        Sumofmatrices();
                        break;
                    case 8:
                        Multiplicationofmatrix();
                        break;
                    case 9:
                         Transposeofmatrix();
                        break;
                      
                    case 10:
                        BinarySearch();
                        break;
                        
                    case 11:
                        BubbleSort();
                        break;
                        
                    case 12:
                        SelectionSort();
                        break;
                    case 13:
                        Insertionsort();
                        break;
                   
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.Write("\n\nenter the serial number of question you want (0 to exit): ");
                inputChoice = Console.ReadLine();
                Console.WriteLine();
                choice = Convert.ToInt32(inputChoice);
            } 
        }      
    }
}

