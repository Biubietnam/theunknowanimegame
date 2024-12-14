using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D25 RID: 3365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordDataChangeNotify : IMessage<PunkLordDataChangeNotify>, IMessage, IEquatable<PunkLordDataChangeNotify>, IDeepCloneable<PunkLordDataChangeNotify>, IBufferMessage
	{
		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600964E RID: 38478 RVA: 0x0018FD21 File Offset: 0x0018DF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordDataChangeNotify> Parser
		{
			get
			{
				return PunkLordDataChangeNotify._parser;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600964F RID: 38479 RVA: 0x0018FD28 File Offset: 0x0018DF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordDataChangeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06009650 RID: 38480 RVA: 0x0018FD3A File Offset: 0x0018DF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x0018FD41 File Offset: 0x0018DF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordDataChangeNotify()
		{
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x0018FD49 File Offset: 0x0018DF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordDataChangeNotify(PunkLordDataChangeNotify other) : this()
		{
			this.jLJDFNHKHOO_ = other.jLJDFNHKHOO_;
			this.gKLLEINMPBL_ = other.gKLLEINMPBL_;
			this.gHHNLAEPDMG_ = other.gHHNLAEPDMG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x0018FD86 File Offset: 0x0018DF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordDataChangeNotify Clone()
		{
			return new PunkLordDataChangeNotify(this);
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06009654 RID: 38484 RVA: 0x0018FD8E File Offset: 0x0018DF8E
		// (set) Token: 0x06009655 RID: 38485 RVA: 0x0018FD96 File Offset: 0x0018DF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JLJDFNHKHOO
		{
			get
			{
				return this.jLJDFNHKHOO_;
			}
			set
			{
				this.jLJDFNHKHOO_ = value;
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x0018FD9F File Offset: 0x0018DF9F
		// (set) Token: 0x06009657 RID: 38487 RVA: 0x0018FDA7 File Offset: 0x0018DFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKLLEINMPBL
		{
			get
			{
				return this.gKLLEINMPBL_;
			}
			set
			{
				this.gKLLEINMPBL_ = value;
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06009658 RID: 38488 RVA: 0x0018FDB0 File Offset: 0x0018DFB0
		// (set) Token: 0x06009659 RID: 38489 RVA: 0x0018FDB8 File Offset: 0x0018DFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHHNLAEPDMG
		{
			get
			{
				return this.gHHNLAEPDMG_;
			}
			set
			{
				this.gHHNLAEPDMG_ = value;
			}
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x0018FDC1 File Offset: 0x0018DFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordDataChangeNotify);
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0018FDD0 File Offset: 0x0018DFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordDataChangeNotify other)
		{
			return other != null && (other == this || (this.JLJDFNHKHOO == other.JLJDFNHKHOO && this.GKLLEINMPBL == other.GKLLEINMPBL && this.GHHNLAEPDMG == other.GHHNLAEPDMG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x0018FE2C File Offset: 0x0018E02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JLJDFNHKHOO != 0U)
			{
				num ^= this.JLJDFNHKHOO.GetHashCode();
			}
			if (this.GKLLEINMPBL != 0U)
			{
				num ^= this.GKLLEINMPBL.GetHashCode();
			}
			if (this.GHHNLAEPDMG != 0U)
			{
				num ^= this.GHHNLAEPDMG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0018FE9D File Offset: 0x0018E09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x0018FEA5 File Offset: 0x0018E0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x0018FEB0 File Offset: 0x0018E0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GKLLEINMPBL != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GKLLEINMPBL);
			}
			if (this.GHHNLAEPDMG != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GHHNLAEPDMG);
			}
			if (this.JLJDFNHKHOO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.JLJDFNHKHOO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x0018FF28 File Offset: 0x0018E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JLJDFNHKHOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JLJDFNHKHOO);
			}
			if (this.GKLLEINMPBL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKLLEINMPBL);
			}
			if (this.GHHNLAEPDMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHHNLAEPDMG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x0018FF98 File Offset: 0x0018E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordDataChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JLJDFNHKHOO != 0U)
			{
				this.JLJDFNHKHOO = other.JLJDFNHKHOO;
			}
			if (other.GKLLEINMPBL != 0U)
			{
				this.GKLLEINMPBL = other.GKLLEINMPBL;
			}
			if (other.GHHNLAEPDMG != 0U)
			{
				this.GHHNLAEPDMG = other.GHHNLAEPDMG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x0018FFFC File Offset: 0x0018E1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x00190008 File Offset: 0x0018E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.JLJDFNHKHOO = input.ReadUInt32();
						}
					}
					else
					{
						this.GHHNLAEPDMG = input.ReadUInt32();
					}
				}
				else
				{
					this.GKLLEINMPBL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003A4B RID: 14923
		private static readonly MessageParser<PunkLordDataChangeNotify> _parser = new MessageParser<PunkLordDataChangeNotify>(() => new PunkLordDataChangeNotify());

		// Token: 0x04003A4C RID: 14924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A4D RID: 14925
		public const int JLJDFNHKHOOFieldNumber = 14;

		// Token: 0x04003A4E RID: 14926
		private uint jLJDFNHKHOO_;

		// Token: 0x04003A4F RID: 14927
		public const int GKLLEINMPBLFieldNumber = 2;

		// Token: 0x04003A50 RID: 14928
		private uint gKLLEINMPBL_;

		// Token: 0x04003A51 RID: 14929
		public const int GHHNLAEPDMGFieldNumber = 12;

		// Token: 0x04003A52 RID: 14930
		private uint gHHNLAEPDMG_;
	}
}
