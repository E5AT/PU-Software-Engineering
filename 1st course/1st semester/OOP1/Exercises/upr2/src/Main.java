
void main() {
//    int[] arr = new int[10];
//    arr[1] = 1;

    int[] arr = {20,10,0,-5,-100,50,500};
    int maxArr = Integer.MIN_VALUE, minArr = Integer.MAX_VALUE;

    for(int i:arr){
        maxArr = Math.max(maxArr,i);
        minArr = Math.min(minArr,i);
    }

    System.out.println("Max arr: "+maxArr);
    System.out.println("Min arr: "+minArr);

    int[] arra = {50, 100, 0, -2, -20, 30};
    for(int j=0;j<arra.length-1;j++){
        if(arra[j]>arra[j+1]){
            int temp = arra[j];
            arra[j] = arra[j+1];
            arra[j+1] = temp;
        }
    }
    for(int j:arra){
        System.out.print(j+" ");
    }
}
