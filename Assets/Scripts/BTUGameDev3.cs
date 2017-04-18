using UnityEngine;

public class BTUGameDev3 : MonoBehaviour
{
    bool a = true;
    bool b = false;
    bool result;

    void Start () {

        result = a && b; // ||

        // true && true = true
        // true && false = false
        // false && true = false
        // false && false = false

        // true || true = true
        // true || false = true
        // false || true = true
        // false || false = false

    }

    int x = 5;
    int y = 8;
    int bitResult;

    void BitwiseOperands()
    {
        

    }


    /* int x;
     * 
     * 0000000000 .... 0 x32
     * 
     * 00000101 = 5 ათობითში
     * |
     * 00001000 = 8 ათობითში
     * 00001101 = 13 ათობითში
     * 
     * 1        1
     * 2        10
     * 3        11
     * 4        100
     * ..
     * 
     * 
     * 
     */
}
