using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000779 RID: 1913
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordBattleRecordCsReq : IMessage<GetPunkLordBattleRecordCsReq>, IMessage, IEquatable<GetPunkLordBattleRecordCsReq>, IDeepCloneable<GetPunkLordBattleRecordCsReq>, IBufferMessage
	{
		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x000E58B5 File Offset: 0x000E3AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordBattleRecordCsReq> Parser
		{
			get
			{
				return GetPunkLordBattleRecordCsReq._parser;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x000E58BC File Offset: 0x000E3ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordBattleRecordCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x000E58CE File Offset: 0x000E3ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordBattleRecordCsReq.Descriptor;
			}
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x000E58D5 File Offset: 0x000E3AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordCsReq()
		{
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x000E58DD File Offset: 0x000E3ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordCsReq(GetPunkLordBattleRecordCsReq other) : this()
		{
			this.lEHPJLFNONE_ = ((other.lEHPJLFNONE_ != null) ? other.lEHPJLFNONE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x000E5912 File Offset: 0x000E3B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordCsReq Clone()
		{
			return new GetPunkLordBattleRecordCsReq(this);
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x000E591A File Offset: 0x000E3B1A
		// (set) Token: 0x0600557D RID: 21885 RVA: 0x000E5922 File Offset: 0x000E3B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey LEHPJLFNONE
		{
			get
			{
				return this.lEHPJLFNONE_;
			}
			set
			{
				this.lEHPJLFNONE_ = value;
			}
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x000E592B File Offset: 0x000E3B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordBattleRecordCsReq);
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x000E5939 File Offset: 0x000E3B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordBattleRecordCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.LEHPJLFNONE, other.LEHPJLFNONE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x000E596C File Offset: 0x000E3B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lEHPJLFNONE_ != null)
			{
				num ^= this.LEHPJLFNONE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x000E59A8 File Offset: 0x000E3BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x000E59B0 File Offset: 0x000E3BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x000E59B9 File Offset: 0x000E3BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lEHPJLFNONE_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LEHPJLFNONE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x000E59EC File Offset: 0x000E3BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lEHPJLFNONE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LEHPJLFNONE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x000E5A2C File Offset: 0x000E3C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordBattleRecordCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lEHPJLFNONE_ != null)
			{
				if (this.lEHPJLFNONE_ == null)
				{
					this.LEHPJLFNONE = new PunkLordMonsterKey();
				}
				this.LEHPJLFNONE.MergeFrom(other.LEHPJLFNONE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x000E5A80 File Offset: 0x000E3C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x000E5A8C File Offset: 0x000E3C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lEHPJLFNONE_ == null)
					{
						this.LEHPJLFNONE = new PunkLordMonsterKey();
					}
					input.ReadMessage(this.LEHPJLFNONE);
				}
			}
		}

		// Token: 0x04002180 RID: 8576
		private static readonly MessageParser<GetPunkLordBattleRecordCsReq> _parser = new MessageParser<GetPunkLordBattleRecordCsReq>(() => new GetPunkLordBattleRecordCsReq());

		// Token: 0x04002181 RID: 8577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002182 RID: 8578
		public const int LEHPJLFNONEFieldNumber = 12;

		// Token: 0x04002183 RID: 8579
		private PunkLordMonsterKey lEHPJLFNONE_;
	}
}
