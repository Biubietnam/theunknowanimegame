using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D1 RID: 465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeStoryLineFinishScNotify : IMessage<ChangeStoryLineFinishScNotify>, IMessage, IEquatable<ChangeStoryLineFinishScNotify>, IDeepCloneable<ChangeStoryLineFinishScNotify>, IBufferMessage
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0003BB97 File Offset: 0x00039D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeStoryLineFinishScNotify> Parser
		{
			get
			{
				return ChangeStoryLineFinishScNotify._parser;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0003BB9E File Offset: 0x00039D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChangeStoryLineFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStoryLineFinishScNotify.Descriptor;
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0003BBB7 File Offset: 0x00039DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStoryLineFinishScNotify()
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0003BBC0 File Offset: 0x00039DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStoryLineFinishScNotify(ChangeStoryLineFinishScNotify other) : this()
		{
			this.oLBODPCNECG_ = other.oLBODPCNECG_;
			this.curStoryLineId_ = other.curStoryLineId_;
			this.action_ = other.action_;
			this.hNFNAEJDDOM_ = other.hNFNAEJDDOM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0003BC14 File Offset: 0x00039E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStoryLineFinishScNotify Clone()
		{
			return new ChangeStoryLineFinishScNotify(this);
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0003BC1C File Offset: 0x00039E1C
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0003BC24 File Offset: 0x00039E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OLBODPCNECG
		{
			get
			{
				return this.oLBODPCNECG_;
			}
			set
			{
				this.oLBODPCNECG_ = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0003BC2D File Offset: 0x00039E2D
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x0003BC35 File Offset: 0x00039E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurStoryLineId
		{
			get
			{
				return this.curStoryLineId_;
			}
			set
			{
				this.curStoryLineId_ = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0003BC3E File Offset: 0x00039E3E
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0003BC46 File Offset: 0x00039E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStoryLineAction Action
		{
			get
			{
				return this.action_;
			}
			set
			{
				this.action_ = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0003BC4F File Offset: 0x00039E4F
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0003BC57 File Offset: 0x00039E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HNFNAEJDDOM
		{
			get
			{
				return this.hNFNAEJDDOM_;
			}
			set
			{
				this.hNFNAEJDDOM_ = value;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0003BC60 File Offset: 0x00039E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStoryLineFinishScNotify);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0003BC70 File Offset: 0x00039E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStoryLineFinishScNotify other)
		{
			return other != null && (other == this || (this.OLBODPCNECG == other.OLBODPCNECG && this.CurStoryLineId == other.CurStoryLineId && this.Action == other.Action && this.HNFNAEJDDOM == other.HNFNAEJDDOM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0003BCDC File Offset: 0x00039EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OLBODPCNECG != 0U)
			{
				num ^= this.OLBODPCNECG.GetHashCode();
			}
			if (this.CurStoryLineId != 0U)
			{
				num ^= this.CurStoryLineId.GetHashCode();
			}
			if (this.Action != ChangeStoryLineAction.None)
			{
				num ^= this.Action.GetHashCode();
			}
			if (this.HNFNAEJDDOM)
			{
				num ^= this.HNFNAEJDDOM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0003BD6C File Offset: 0x00039F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0003BD74 File Offset: 0x00039F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0003BD80 File Offset: 0x00039F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurStoryLineId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurStoryLineId);
			}
			if (this.OLBODPCNECG != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.OLBODPCNECG);
			}
			if (this.HNFNAEJDDOM)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HNFNAEJDDOM);
			}
			if (this.Action != ChangeStoryLineAction.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Action);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0003BE14 File Offset: 0x0003A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OLBODPCNECG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OLBODPCNECG);
			}
			if (this.CurStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurStoryLineId);
			}
			if (this.Action != ChangeStoryLineAction.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Action);
			}
			if (this.HNFNAEJDDOM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0003BE90 File Offset: 0x0003A090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStoryLineFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OLBODPCNECG != 0U)
			{
				this.OLBODPCNECG = other.OLBODPCNECG;
			}
			if (other.CurStoryLineId != 0U)
			{
				this.CurStoryLineId = other.CurStoryLineId;
			}
			if (other.Action != ChangeStoryLineAction.None)
			{
				this.Action = other.Action;
			}
			if (other.HNFNAEJDDOM)
			{
				this.HNFNAEJDDOM = other.HNFNAEJDDOM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0003BF08 File Offset: 0x0003A108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0003BF14 File Offset: 0x0003A114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.CurStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.OLBODPCNECG = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HNFNAEJDDOM = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Action = (ChangeStoryLineAction)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040008BA RID: 2234
		private static readonly MessageParser<ChangeStoryLineFinishScNotify> _parser = new MessageParser<ChangeStoryLineFinishScNotify>(() => new ChangeStoryLineFinishScNotify());

		// Token: 0x040008BB RID: 2235
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008BC RID: 2236
		public const int OLBODPCNECGFieldNumber = 7;

		// Token: 0x040008BD RID: 2237
		private uint oLBODPCNECG_;

		// Token: 0x040008BE RID: 2238
		public const int CurStoryLineIdFieldNumber = 3;

		// Token: 0x040008BF RID: 2239
		private uint curStoryLineId_;

		// Token: 0x040008C0 RID: 2240
		public const int ActionFieldNumber = 14;

		// Token: 0x040008C1 RID: 2241
		private ChangeStoryLineAction action_;

		// Token: 0x040008C2 RID: 2242
		public const int HNFNAEJDDOMFieldNumber = 11;

		// Token: 0x040008C3 RID: 2243
		private bool hNFNAEJDDOM_;
	}
}
