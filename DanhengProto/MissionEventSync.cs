using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE1 RID: 2785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionEventSync : IMessage<MissionEventSync>, IMessage, IEquatable<MissionEventSync>, IDeepCloneable<MissionEventSync>, IBufferMessage
	{
		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x00146775 File Offset: 0x00144975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionEventSync> Parser
		{
			get
			{
				return MissionEventSync._parser;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x0014677C File Offset: 0x0014497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionEventSyncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06007B5F RID: 31583 RVA: 0x0014678E File Offset: 0x0014498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionEventSync.Descriptor;
			}
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x00146795 File Offset: 0x00144995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventSync()
		{
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x001467C0 File Offset: 0x001449C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventSync(MissionEventSync other) : this()
		{
			this.bBAOBMPIDIN_ = other.bBAOBMPIDIN_.Clone();
			this.fEHNBOKNGEK_ = other.fEHNBOKNGEK_.Clone();
			this.missionEventList_ = other.missionEventList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x00146817 File Offset: 0x00144A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventSync Clone()
		{
			return new MissionEventSync(this);
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x0014681F File Offset: 0x00144A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BBAOBMPIDIN
		{
			get
			{
				return this.bBAOBMPIDIN_;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06007B64 RID: 31588 RVA: 0x00146827 File Offset: 0x00144A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FEHNBOKNGEK
		{
			get
			{
				return this.fEHNBOKNGEK_;
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x0014682F File Offset: 0x00144A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> MissionEventList
		{
			get
			{
				return this.missionEventList_;
			}
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x00146837 File Offset: 0x00144A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionEventSync);
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x00146848 File Offset: 0x00144A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionEventSync other)
		{
			return other != null && (other == this || (this.bBAOBMPIDIN_.Equals(other.bBAOBMPIDIN_) && this.fEHNBOKNGEK_.Equals(other.fEHNBOKNGEK_) && this.missionEventList_.Equals(other.missionEventList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x001468B0 File Offset: 0x00144AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bBAOBMPIDIN_.GetHashCode();
			num ^= this.fEHNBOKNGEK_.GetHashCode();
			num ^= this.missionEventList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x00146900 File Offset: 0x00144B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x00146908 File Offset: 0x00144B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x00146914 File Offset: 0x00144B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fEHNBOKNGEK_.WriteTo(ref output, MissionEventSync._repeated_fEHNBOKNGEK_codec);
			this.missionEventList_.WriteTo(ref output, MissionEventSync._repeated_missionEventList_codec);
			this.bBAOBMPIDIN_.WriteTo(ref output, MissionEventSync._repeated_bBAOBMPIDIN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x00146968 File Offset: 0x00144B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bBAOBMPIDIN_.CalculateSize(MissionEventSync._repeated_bBAOBMPIDIN_codec);
			num += this.fEHNBOKNGEK_.CalculateSize(MissionEventSync._repeated_fEHNBOKNGEK_codec);
			num += this.missionEventList_.CalculateSize(MissionEventSync._repeated_missionEventList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x001469C8 File Offset: 0x00144BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionEventSync other)
		{
			if (other == null)
			{
				return;
			}
			this.bBAOBMPIDIN_.Add(other.bBAOBMPIDIN_);
			this.fEHNBOKNGEK_.Add(other.fEHNBOKNGEK_);
			this.missionEventList_.Add(other.missionEventList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x00146A23 File Offset: 0x00144C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x00146A2C File Offset: 0x00144C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.fEHNBOKNGEK_.AddEntriesFrom(ref input, MissionEventSync._repeated_fEHNBOKNGEK_codec);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.missionEventList_.AddEntriesFrom(ref input, MissionEventSync._repeated_missionEventList_codec);
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.bBAOBMPIDIN_.AddEntriesFrom(ref input, MissionEventSync._repeated_bBAOBMPIDIN_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F4E RID: 12110
		private static readonly MessageParser<MissionEventSync> _parser = new MessageParser<MissionEventSync>(() => new MissionEventSync());

		// Token: 0x04002F4F RID: 12111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F50 RID: 12112
		public const int BBAOBMPIDINFieldNumber = 15;

		// Token: 0x04002F51 RID: 12113
		private static readonly FieldCodec<uint> _repeated_bBAOBMPIDIN_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04002F52 RID: 12114
		private readonly RepeatedField<uint> bBAOBMPIDIN_ = new RepeatedField<uint>();

		// Token: 0x04002F53 RID: 12115
		public const int FEHNBOKNGEKFieldNumber = 3;

		// Token: 0x04002F54 RID: 12116
		private static readonly FieldCodec<uint> _repeated_fEHNBOKNGEK_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002F55 RID: 12117
		private readonly RepeatedField<uint> fEHNBOKNGEK_ = new RepeatedField<uint>();

		// Token: 0x04002F56 RID: 12118
		public const int MissionEventListFieldNumber = 11;

		// Token: 0x04002F57 RID: 12119
		private static readonly FieldCodec<Mission> _repeated_missionEventList_codec = FieldCodec.ForMessage<Mission>(90U, Mission.Parser);

		// Token: 0x04002F58 RID: 12120
		private readonly RepeatedField<Mission> missionEventList_ = new RepeatedField<Mission>();
	}
}
