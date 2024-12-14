using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001091 RID: 4241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SearchPlayerCsReq : IMessage<SearchPlayerCsReq>, IMessage, IEquatable<SearchPlayerCsReq>, IDeepCloneable<SearchPlayerCsReq>, IBufferMessage
	{
		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x001FDC08 File Offset: 0x001FBE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SearchPlayerCsReq> Parser
		{
			get
			{
				return SearchPlayerCsReq._parser;
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x001FDC0F File Offset: 0x001FBE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchPlayerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600BD20 RID: 48416 RVA: 0x001FDC21 File Offset: 0x001FBE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SearchPlayerCsReq.Descriptor;
			}
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x001FDC28 File Offset: 0x001FBE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerCsReq()
		{
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x001FDC3B File Offset: 0x001FBE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerCsReq(SearchPlayerCsReq other) : this()
		{
			this.uidList_ = other.uidList_.Clone();
			this.cOBDHLMALKI_ = other.cOBDHLMALKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x001FDC71 File Offset: 0x001FBE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerCsReq Clone()
		{
			return new SearchPlayerCsReq(this);
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x001FDC79 File Offset: 0x001FBE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UidList
		{
			get
			{
				return this.uidList_;
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600BD25 RID: 48421 RVA: 0x001FDC81 File Offset: 0x001FBE81
		// (set) Token: 0x0600BD26 RID: 48422 RVA: 0x001FDC89 File Offset: 0x001FBE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool COBDHLMALKI
		{
			get
			{
				return this.cOBDHLMALKI_;
			}
			set
			{
				this.cOBDHLMALKI_ = value;
			}
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x001FDC92 File Offset: 0x001FBE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SearchPlayerCsReq);
		}

		// Token: 0x0600BD28 RID: 48424 RVA: 0x001FDCA0 File Offset: 0x001FBEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SearchPlayerCsReq other)
		{
			return other != null && (other == this || (this.uidList_.Equals(other.uidList_) && this.COBDHLMALKI == other.COBDHLMALKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x001FDCF0 File Offset: 0x001FBEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.uidList_.GetHashCode();
			if (this.COBDHLMALKI)
			{
				num ^= this.COBDHLMALKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x001FDD3D File Offset: 0x001FBF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD2B RID: 48427 RVA: 0x001FDD45 File Offset: 0x001FBF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x001FDD50 File Offset: 0x001FBF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.uidList_.WriteTo(ref output, SearchPlayerCsReq._repeated_uidList_codec);
			if (this.COBDHLMALKI)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.COBDHLMALKI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x001FDDA0 File Offset: 0x001FBFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.uidList_.CalculateSize(SearchPlayerCsReq._repeated_uidList_codec);
			if (this.COBDHLMALKI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x001FDDE8 File Offset: 0x001FBFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SearchPlayerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.uidList_.Add(other.uidList_);
			if (other.COBDHLMALKI)
			{
				this.COBDHLMALKI = other.COBDHLMALKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x001FDE35 File Offset: 0x001FC035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD30 RID: 48432 RVA: 0x001FDE40 File Offset: 0x001FC040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.COBDHLMALKI = input.ReadBool();
					}
				}
				else
				{
					this.uidList_.AddEntriesFrom(ref input, SearchPlayerCsReq._repeated_uidList_codec);
				}
			}
		}

		// Token: 0x04004CE7 RID: 19687
		private static readonly MessageParser<SearchPlayerCsReq> _parser = new MessageParser<SearchPlayerCsReq>(() => new SearchPlayerCsReq());

		// Token: 0x04004CE8 RID: 19688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CE9 RID: 19689
		public const int UidListFieldNumber = 14;

		// Token: 0x04004CEA RID: 19690
		private static readonly FieldCodec<uint> _repeated_uidList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04004CEB RID: 19691
		private readonly RepeatedField<uint> uidList_ = new RepeatedField<uint>();

		// Token: 0x04004CEC RID: 19692
		public const int COBDHLMALKIFieldNumber = 15;

		// Token: 0x04004CED RID: 19693
		private bool cOBDHLMALKI_;
	}
}
