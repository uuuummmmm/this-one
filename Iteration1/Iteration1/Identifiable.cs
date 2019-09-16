using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
        class Identifiable
        {
            private List<string> _identifiers;

            public readonly string FirstId;

            public Identifiable(List<string> idents)
            {
                _identifiers = idents;

                if (_identifiers.Count() < 1)
                {
                    FirstId = "";
                }
                else
                {
                    FirstId = _identifiers[0];
                }
            }

            public bool AreYou(string id)
            {
                id = id.ToLower();
                foreach (string temp_id in _identifiers)
                {
                    if (id == temp_id)
                    {
                        return true;
                    }
                }
                return false;
            }

            public void AddIdentifier(string id)
            {
                id = id.ToLower();

                _identifiers.Add(id);
            }
        }

    }
