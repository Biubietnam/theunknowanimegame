using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001127 RID: 4391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetRogueCollectionCsReq : IMessage<SetRogueCollectionCsReq>, IMessage, IEquatable<SetRogueCollectionCsReq>, IDeepCloneable<SetRogueCollectionCsReq>, IBufferMessage
	{
		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600C3D3 RID: 50131 RVA: 0x0020D9D7 File Offset: 0x0020BBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetRogueCollectionCsReq> Parser
		{
			get
			{
				return SetRogueCollectionCsReq._parser;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600C3D4 RID: 50132 RVA: 0x0020D9DE File Offset: 0x0020BBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetRogueCollectionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600C3D5 RID: 50133 RVA: 0x0020D9F0 File Offset: 0x0020BBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRogueCollectionCsReq.Descriptor;
			}
		}

		// Token: 0x0600C3D6 RID: 50134 RVA: 0x0020D9F7 File Offset: 0x0020BBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionCsReq()
		{
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x0020DA20 File Offset: 0x0020BC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionCsReq(SetRogueCollectionCsReq other) : this()
		{
			this.fNLPOAHGGOE_ = other.fNLPOAHGGOE_.Clone();
			this.mLLJGOKFLNL_ = other.mLLJGOKFLNL_.Clone();
			this.bAMBPIGOMBO_ = other.bAMBPIGOMBO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x0020DA77 File Offset: 0x0020BC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionCsReq Clone()
		{
			return new SetRogueCollectionCsReq(this);
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600C3D9 RID: 50137 RVA: 0x0020DA7F File Offset: 0x0020BC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FNLPOAHGGOE
		{
			get
			{
				return this.fNLPOAHGGOE_;
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600C3DA RID: 50138 RVA: 0x0020DA87 File Offset: 0x0020BC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MLLJGOKFLNL
		{
			get
			{
				return this.mLLJGOKFLNL_;
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x0020DA8F File Offset: 0x0020BC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCollectionExhibitionOperateType> BAMBPIGOMBO
		{
			get
			{
				return this.bAMBPIGOMBO_;
			}
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x0020DA97 File Offset: 0x0020BC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetRogueCollectionCsReq);
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x0020DAA8 File Offset: 0x0020BCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetRogueCollectionCsReq other)
		{
			return other != null && (other == this || (this.fNLPOAHGGOE_.Equals(other.fNLPOAHGGOE_) && this.mLLJGOKFLNL_.Equals(other.mLLJGOKFLNL_) && this.bAMBPIGOMBO_.Equals(other.bAMBPIGOMBO_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3DE RID: 50142 RVA: 0x0020DB10 File Offset: 0x0020BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fNLPOAHGGOE_.GetHashCode();
			num ^= this.mLLJGOKFLNL_.GetHashCode();
			num ^= this.bAMBPIGOMBO_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3DF RID: 50143 RVA: 0x0020DB60 File Offset: 0x0020BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C3E0 RID: 50144 RVA: 0x0020DB68 File Offset: 0x0020BD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x0020DB74 File Offset: 0x0020BD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mLLJGOKFLNL_.WriteTo(ref output, SetRogueCollectionCsReq._repeated_mLLJGOKFLNL_codec);
			this.bAMBPIGOMBO_.WriteTo(ref output, SetRogueCollectionCsReq._repeated_bAMBPIGOMBO_codec);
			this.fNLPOAHGGOE_.WriteTo(ref output, SetRogueCollectionCsReq._repeated_fNLPOAHGGOE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x0020DBC8 File Offset: 0x0020BDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fNLPOAHGGOE_.CalculateSize(SetRogueCollectionCsReq._repeated_fNLPOAHGGOE_codec);
			num += this.mLLJGOKFLNL_.CalculateSize(SetRogueCollectionCsReq._repeated_mLLJGOKFLNL_codec);
			num += this.bAMBPIGOMBO_.CalculateSize(SetRogueCollectionCsReq._repeated_bAMBPIGOMBO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x0020DC28 File Offset: 0x0020BE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetRogueCollectionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.fNLPOAHGGOE_.Add(other.fNLPOAHGGOE_);
			this.mLLJGOKFLNL_.Add(other.mLLJGOKFLNL_);
			this.bAMBPIGOMBO_.Add(other.bAMBPIGOMBO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x0020DC83 File Offset: 0x0020BE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x0020DC8C File Offset: 0x0020BE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 48U || num == 50U)
					{
						this.mLLJGOKFLNL_.AddEntriesFrom(ref input, SetRogueCollectionCsReq._repeated_mLLJGOKFLNL_codec);
						continue;
					}
					if (num == 72U)
					{
						goto IL_4E;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4E;
					}
					if (num == 104U || num == 106U)
					{
						this.fNLPOAHGGOE_.AddEntriesFrom(ref input, SetRogueCollectionCsReq._repeated_fNLPOAHGGOE_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4E:
				this.bAMBPIGOMBO_.AddEntriesFrom(ref input, SetRogueCollectionCsReq._repeated_bAMBPIGOMBO_codec);
			}
		}

		// Token: 0x04004F1E RID: 20254
		private static readonly MessageParser<SetRogueCollectionCsReq> _parser = new MessageParser<SetRogueCollectionCsReq>(() => new SetRogueCollectionCsReq());

		// Token: 0x04004F1F RID: 20255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F20 RID: 20256
		public const int FNLPOAHGGOEFieldNumber = 13;

		// Token: 0x04004F21 RID: 20257
		private static readonly FieldCodec<uint> _repeated_fNLPOAHGGOE_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04004F22 RID: 20258
		private readonly RepeatedField<uint> fNLPOAHGGOE_ = new RepeatedField<uint>();

		// Token: 0x04004F23 RID: 20259
		public const int MLLJGOKFLNLFieldNumber = 6;

		// Token: 0x04004F24 RID: 20260
		private static readonly FieldCodec<uint> _repeated_mLLJGOKFLNL_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04004F25 RID: 20261
		private readonly RepeatedField<uint> mLLJGOKFLNL_ = new RepeatedField<uint>();

		// Token: 0x04004F26 RID: 20262
		public const int BAMBPIGOMBOFieldNumber = 9;

		// Token: 0x04004F27 RID: 20263
		private static readonly FieldCodec<RogueCollectionExhibitionOperateType> _repeated_bAMBPIGOMBO_codec = FieldCodec.ForEnum<RogueCollectionExhibitionOperateType>(74U, (RogueCollectionExhibitionOperateType x) => (int)x, (int x) => (RogueCollectionExhibitionOperateType)x);

		// Token: 0x04004F28 RID: 20264
		private readonly RepeatedField<RogueCollectionExhibitionOperateType> bAMBPIGOMBO_ = new RepeatedField<RogueCollectionExhibitionOperateType>();
	}
}
