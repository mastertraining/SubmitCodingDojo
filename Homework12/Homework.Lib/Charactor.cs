using System;
using System.Linq;

namespace Homework.Lib {
    public class Charactor : IHomework12 {
        public char FirstDuplicateCharactor (string text) {
            var cha = text.ToCharArray ();
            for (int i = 0; i < cha.Length - 1; i++) {
                for (int j = 0; j < cha.Length - 1; j++) {
                    if (cha[i] == cha[j + 1]) {
                        return cha[i];
                    }
                }
            }
            return '-';
        }

        public char FirstNotDuplicateCharactor (string text) {
            var cha = text.ToCharArray ().GroupBy (it => it).FirstOrDefault (it => it.Count () == 1);
            if(cha != null){
                return cha.Key;
            }
            return '-';
        }
    }
}