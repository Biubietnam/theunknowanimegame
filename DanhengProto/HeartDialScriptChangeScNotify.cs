using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A1 RID: 2209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeartDialScriptChangeScNotify : IMessage<HeartDialScriptChangeScNotify>, IMessage, IEquatable<HeartDialScriptChangeScNotify>, IDeepCloneable<HeartDialScriptChangeScNotify>, IBufferMessage
	{
		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06006282 RID: 25218 RVA: 0x001079FD File Offset: 0x00105BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeartDialScriptChangeScNotify> Parser
		{
			get
			{
				return HeartDialScriptChangeScNotify._parser;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x00107A04 File Offset: 0x00105C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeartDialScriptChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x00107A16 File Offset: 0x00105C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartDialScriptChangeScNotify.Descriptor;
			}
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00107A1D File Offset: 0x00105C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptChangeScNotify()
		{
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00107A48 File Offset: 0x00105C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptChangeScNotify(HeartDialScriptChangeScNotify other) : this()
		{
			this.nDKJOPLLDPH_ = other.nDKJOPLLDPH_.Clone();
			this.unlockStatus_ = other.unlockStatus_;
			this.changedScriptInfoList_ = other.changedScriptInfoList_.Clone();
			this.changedDialogueInfoList_ = other.changedDialogueInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x00107AAB File Offset: 0x00105CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptChangeScNotify Clone()
		{
			return new HeartDialScriptChangeScNotify(this);
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06006288 RID: 25224 RVA: 0x00107AB3 File Offset: 0x00105CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KGHFJPEGBNL> NDKJOPLLDPH
		{
			get
			{
				return this.nDKJOPLLDPH_;
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x00107ABB File Offset: 0x00105CBB
		// (set) Token: 0x0600628A RID: 25226 RVA: 0x00107AC3 File Offset: 0x00105CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialUnlockStatus UnlockStatus
		{
			get
			{
				return this.unlockStatus_;
			}
			set
			{
				this.unlockStatus_ = value;
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x00107ACC File Offset: 0x00105CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeartDialScriptInfo> ChangedScriptInfoList
		{
			get
			{
				return this.changedScriptInfoList_;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x00107AD4 File Offset: 0x00105CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeartDialDialogueInfo> ChangedDialogueInfoList
		{
			get
			{
				return this.changedDialogueInfoList_;
			}
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00107ADC File Offset: 0x00105CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartDialScriptChangeScNotify);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00107AEC File Offset: 0x00105CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartDialScriptChangeScNotify other)
		{
			return other != null && (other == this || (this.nDKJOPLLDPH_.Equals(other.nDKJOPLLDPH_) && this.UnlockStatus == other.UnlockStatus && this.changedScriptInfoList_.Equals(other.changedScriptInfoList_) && this.changedDialogueInfoList_.Equals(other.changedDialogueInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00107B64 File Offset: 0x00105D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nDKJOPLLDPH_.GetHashCode();
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				num ^= this.UnlockStatus.GetHashCode();
			}
			num ^= this.changedScriptInfoList_.GetHashCode();
			num ^= this.changedDialogueInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00107BD3 File Offset: 0x00105DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00107BDB File Offset: 0x00105DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00107BE4 File Offset: 0x00105DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changedDialogueInfoList_.WriteTo(ref output, HeartDialScriptChangeScNotify._repeated_changedDialogueInfoList_codec);
			this.nDKJOPLLDPH_.WriteTo(ref output, HeartDialScriptChangeScNotify._repeated_nDKJOPLLDPH_codec);
			this.changedScriptInfoList_.WriteTo(ref output, HeartDialScriptChangeScNotify._repeated_changedScriptInfoList_codec);
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.UnlockStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00107C54 File Offset: 0x00105E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nDKJOPLLDPH_.CalculateSize(HeartDialScriptChangeScNotify._repeated_nDKJOPLLDPH_codec);
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UnlockStatus);
			}
			num += this.changedScriptInfoList_.CalculateSize(HeartDialScriptChangeScNotify._repeated_changedScriptInfoList_codec);
			num += this.changedDialogueInfoList_.CalculateSize(HeartDialScriptChangeScNotify._repeated_changedDialogueInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00107CCC File Offset: 0x00105ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartDialScriptChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.nDKJOPLLDPH_.Add(other.nDKJOPLLDPH_);
			if (other.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				this.UnlockStatus = other.UnlockStatus;
			}
			this.changedScriptInfoList_.Add(other.changedScriptInfoList_);
			this.changedDialogueInfoList_.Add(other.changedDialogueInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00107D3B File Offset: 0x00105F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00107D44 File Offset: 0x00105F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 26U)
					{
						this.changedDialogueInfoList_.AddEntriesFrom(ref input, HeartDialScriptChangeScNotify._repeated_changedDialogueInfoList_codec);
						continue;
					}
					if (num == 34U)
					{
						this.nDKJOPLLDPH_.AddEntriesFrom(ref input, HeartDialScriptChangeScNotify._repeated_nDKJOPLLDPH_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.changedScriptInfoList_.AddEntriesFrom(ref input, HeartDialScriptChangeScNotify._repeated_changedScriptInfoList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.UnlockStatus = (HeartDialUnlockStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025DE RID: 9694
		private static readonly MessageParser<HeartDialScriptChangeScNotify> _parser = new MessageParser<HeartDialScriptChangeScNotify>(() => new HeartDialScriptChangeScNotify());

		// Token: 0x040025DF RID: 9695
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025E0 RID: 9696
		public const int NDKJOPLLDPHFieldNumber = 4;

		// Token: 0x040025E1 RID: 9697
		private static readonly FieldCodec<KGHFJPEGBNL> _repeated_nDKJOPLLDPH_codec = FieldCodec.ForMessage<KGHFJPEGBNL>(34U, KGHFJPEGBNL.Parser);

		// Token: 0x040025E2 RID: 9698
		private readonly RepeatedField<KGHFJPEGBNL> nDKJOPLLDPH_ = new RepeatedField<KGHFJPEGBNL>();

		// Token: 0x040025E3 RID: 9699
		public const int UnlockStatusFieldNumber = 15;

		// Token: 0x040025E4 RID: 9700
		private HeartDialUnlockStatus unlockStatus_;

		// Token: 0x040025E5 RID: 9701
		public const int ChangedScriptInfoListFieldNumber = 12;

		// Token: 0x040025E6 RID: 9702
		private static readonly FieldCodec<HeartDialScriptInfo> _repeated_changedScriptInfoList_codec = FieldCodec.ForMessage<HeartDialScriptInfo>(98U, HeartDialScriptInfo.Parser);

		// Token: 0x040025E7 RID: 9703
		private readonly RepeatedField<HeartDialScriptInfo> changedScriptInfoList_ = new RepeatedField<HeartDialScriptInfo>();

		// Token: 0x040025E8 RID: 9704
		public const int ChangedDialogueInfoListFieldNumber = 3;

		// Token: 0x040025E9 RID: 9705
		private static readonly FieldCodec<HeartDialDialogueInfo> _repeated_changedDialogueInfoList_codec = FieldCodec.ForMessage<HeartDialDialogueInfo>(26U, HeartDialDialogueInfo.Parser);

		// Token: 0x040025EA RID: 9706
		private readonly RepeatedField<HeartDialDialogueInfo> changedDialogueInfoList_ = new RepeatedField<HeartDialDialogueInfo>();
	}
}
