void main() {
    int[] arr = {50, 100, 0, -2, -20, 30};
    for(int i=0;i<arr.length;i++){
        for(int j=i+1;j<arr.length;j++){
            if(arr[i]>arr[j]){
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    for(int i:arr){
        System.out.print(i+" ");
    }
}