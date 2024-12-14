using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000119 RID: 281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BFGPPMDHKJH : IMessage<BFGPPMDHKJH>, IMessage, IEquatable<BFGPPMDHKJH>, IDeepCloneable<BFGPPMDHKJH>, IBufferMessage
	{
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00026210 File Offset: 0x00024410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BFGPPMDHKJH> Parser
		{
			get
			{
				return BFGPPMDHKJH._parser;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00026217 File Offset: 0x00024417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BFGPPMDHKJHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00026229 File Offset: 0x00024429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BFGPPMDHKJH.Descriptor;
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00026230 File Offset: 0x00024430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFGPPMDHKJH()
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00026238 File Offset: 0x00024438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFGPPMDHKJH(BFGPPMDHKJH other) : this()
		{
			this.iGGCDKOECGN_ = other.iGGCDKOECGN_;
			this.cnt_ = other.cnt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00026269 File Offset: 0x00024469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFGPPMDHKJH Clone()
		{
			return new BFGPPMDHKJH(this);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00026271 File Offset: 0x00024471
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00026279 File Offset: 0x00024479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IGGCDKOECGN
		{
			get
			{
				return this.iGGCDKOECGN_;
			}
			set
			{
				this.iGGCDKOECGN_ = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00026282 File Offset: 0x00024482
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0002628A File Offset: 0x0002448A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Cnt
		{
			get
			{
				return this.cnt_;
			}
			set
			{
				this.cnt_ = value;
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00026293 File Offset: 0x00024493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BFGPPMDHKJH);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000262A1 File Offset: 0x000244A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BFGPPMDHKJH other)
		{
			return other != null && (other == this || (this.IGGCDKOECGN == other.IGGCDKOECGN && this.Cnt == other.Cnt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000262E0 File Offset: 0x000244E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IGGCDKOECGN != 0U)
			{
				num ^= this.IGGCDKOECGN.GetHashCode();
			}
			if (this.Cnt != 0U)
			{
				num ^= this.Cnt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00026338 File Offset: 0x00024538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00026340 File Offset: 0x00024540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0002634C File Offset: 0x0002454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cnt != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Cnt);
			}
			if (this.IGGCDKOECGN != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.IGGCDKOECGN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000263A8 File Offset: 0x000245A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IGGCDKOECGN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IGGCDKOECGN);
			}
			if (this.Cnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Cnt);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00026400 File Offset: 0x00024600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BFGPPMDHKJH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IGGCDKOECGN != 0U)
			{
				this.IGGCDKOECGN = other.IGGCDKOECGN;
			}
			if (other.Cnt != 0U)
			{
				this.Cnt = other.Cnt;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00026450 File Offset: 0x00024650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0002645C File Offset: 0x0002465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IGGCDKOECGN = input.ReadUInt32();
					}
				}
				else
				{
					this.Cnt = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000584 RID: 1412
		private static readonly MessageParser<BFGPPMDHKJH> _parser = new MessageParser<BFGPPMDHKJH>(() => new BFGPPMDHKJH());

		// Token: 0x04000585 RID: 1413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000586 RID: 1414
		public const int IGGCDKOECGNFieldNumber = 15;

		// Token: 0x04000587 RID: 1415
		private uint iGGCDKOECGN_;

		// Token: 0x04000588 RID: 1416
		public const int CntFieldNumber = 13;

		// Token: 0x04000589 RID: 1417
		private uint cnt_;
	}
}
