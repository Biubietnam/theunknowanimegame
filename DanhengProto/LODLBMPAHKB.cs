using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A5D RID: 2653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LODLBMPAHKB : IMessage<LODLBMPAHKB>, IMessage, IEquatable<LODLBMPAHKB>, IDeepCloneable<LODLBMPAHKB>, IBufferMessage
	{
		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x001384D9 File Offset: 0x001366D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LODLBMPAHKB> Parser
		{
			get
			{
				return LODLBMPAHKB._parser;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600759F RID: 30111 RVA: 0x001384E0 File Offset: 0x001366E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LODLBMPAHKBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x001384F2 File Offset: 0x001366F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LODLBMPAHKB.Descriptor;
			}
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x001384F9 File Offset: 0x001366F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LODLBMPAHKB()
		{
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00138504 File Offset: 0x00136704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LODLBMPAHKB(LODLBMPAHKB other) : this()
		{
			this.iOEDMMFMFJB_ = other.iOEDMMFMFJB_;
			this.blackList_ = ((other.blackList_ != null) ? other.blackList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00138550 File Offset: 0x00136750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LODLBMPAHKB Clone()
		{
			return new LODLBMPAHKB(this);
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x060075A4 RID: 30116 RVA: 0x00138558 File Offset: 0x00136758
		// (set) Token: 0x060075A5 RID: 30117 RVA: 0x00138560 File Offset: 0x00136760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IOEDMMFMFJB
		{
			get
			{
				return this.iOEDMMFMFJB_;
			}
			set
			{
				this.iOEDMMFMFJB_ = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x060075A6 RID: 30118 RVA: 0x00138569 File Offset: 0x00136769
		// (set) Token: 0x060075A7 RID: 30119 RVA: 0x00138571 File Offset: 0x00136771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO BlackList
		{
			get
			{
				return this.blackList_;
			}
			set
			{
				this.blackList_ = value;
			}
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x0013857A File Offset: 0x0013677A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LODLBMPAHKB);
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00138588 File Offset: 0x00136788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LODLBMPAHKB other)
		{
			return other != null && (other == this || (this.IOEDMMFMFJB == other.IOEDMMFMFJB && object.Equals(this.BlackList, other.BlackList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x001385D8 File Offset: 0x001367D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IOEDMMFMFJB)
			{
				num ^= this.IOEDMMFMFJB.GetHashCode();
			}
			if (this.blackList_ != null)
			{
				num ^= this.BlackList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x0013862D File Offset: 0x0013682D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00138635 File Offset: 0x00136835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00138640 File Offset: 0x00136840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IOEDMMFMFJB)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IOEDMMFMFJB);
			}
			if (this.blackList_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.BlackList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00138698 File Offset: 0x00136898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IOEDMMFMFJB)
			{
				num += 2;
			}
			if (this.blackList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x001386E4 File Offset: 0x001368E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LODLBMPAHKB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IOEDMMFMFJB)
			{
				this.IOEDMMFMFJB = other.IOEDMMFMFJB;
			}
			if (other.blackList_ != null)
			{
				if (this.blackList_ == null)
				{
					this.BlackList = new LLEOAGKMAIO();
				}
				this.BlackList.MergeFrom(other.BlackList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x0013874C File Offset: 0x0013694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00138758 File Offset: 0x00136958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.blackList_ == null)
						{
							this.BlackList = new LLEOAGKMAIO();
						}
						input.ReadMessage(this.BlackList);
					}
				}
				else
				{
					this.IOEDMMFMFJB = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D3A RID: 11578
		private static readonly MessageParser<LODLBMPAHKB> _parser = new MessageParser<LODLBMPAHKB>(() => new LODLBMPAHKB());

		// Token: 0x04002D3B RID: 11579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3C RID: 11580
		public const int IOEDMMFMFJBFieldNumber = 1;

		// Token: 0x04002D3D RID: 11581
		private bool iOEDMMFMFJB_;

		// Token: 0x04002D3E RID: 11582
		public const int BlackListFieldNumber = 10;

		// Token: 0x04002D3F RID: 11583
		private LLEOAGKMAIO blackList_;
	}
}
