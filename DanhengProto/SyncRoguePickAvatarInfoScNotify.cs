using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001297 RID: 4759
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRoguePickAvatarInfoScNotify : IMessage<SyncRoguePickAvatarInfoScNotify>, IMessage, IEquatable<SyncRoguePickAvatarInfoScNotify>, IDeepCloneable<SyncRoguePickAvatarInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600D44F RID: 54351 RVA: 0x00236F21 File Offset: 0x00235121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRoguePickAvatarInfoScNotify> Parser
		{
			get
			{
				return SyncRoguePickAvatarInfoScNotify._parser;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600D450 RID: 54352 RVA: 0x00236F28 File Offset: 0x00235128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRoguePickAvatarInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600D451 RID: 54353 RVA: 0x00236F3A File Offset: 0x0023513A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRoguePickAvatarInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x00236F41 File Offset: 0x00235141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRoguePickAvatarInfoScNotify()
		{
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x00236F5F File Offset: 0x0023515F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRoguePickAvatarInfoScNotify(SyncRoguePickAvatarInfoScNotify other) : this()
		{
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x00236F9A File Offset: 0x0023519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRoguePickAvatarInfoScNotify Clone()
		{
			return new SyncRoguePickAvatarInfoScNotify(this);
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600D455 RID: 54357 RVA: 0x00236FA2 File Offset: 0x002351A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x00236FAA File Offset: 0x002351AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x00236FB2 File Offset: 0x002351B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRoguePickAvatarInfoScNotify);
		}

		// Token: 0x0600D458 RID: 54360 RVA: 0x00236FC0 File Offset: 0x002351C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRoguePickAvatarInfoScNotify other)
		{
			return other != null && (other == this || (this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x00237014 File Offset: 0x00235214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x00237056 File Offset: 0x00235256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D45B RID: 54363 RVA: 0x0023705E File Offset: 0x0023525E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x00237067 File Offset: 0x00235267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialAvatarIdList_.WriteTo(ref output, SyncRoguePickAvatarInfoScNotify._repeated_trialAvatarIdList_codec);
			this.baseAvatarIdList_.WriteTo(ref output, SyncRoguePickAvatarInfoScNotify._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x002370A0 File Offset: 0x002352A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialAvatarIdList_.CalculateSize(SyncRoguePickAvatarInfoScNotify._repeated_trialAvatarIdList_codec);
			num += this.baseAvatarIdList_.CalculateSize(SyncRoguePickAvatarInfoScNotify._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x002370EC File Offset: 0x002352EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRoguePickAvatarInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x0023712B File Offset: 0x0023532B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x00237134 File Offset: 0x00235334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, SyncRoguePickAvatarInfoScNotify._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				else if (num == 32U || num == 34U)
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, SyncRoguePickAvatarInfoScNotify._repeated_baseAvatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040054F7 RID: 21751
		private static readonly MessageParser<SyncRoguePickAvatarInfoScNotify> _parser = new MessageParser<SyncRoguePickAvatarInfoScNotify>(() => new SyncRoguePickAvatarInfoScNotify());

		// Token: 0x040054F8 RID: 21752
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F9 RID: 21753
		public const int TrialAvatarIdListFieldNumber = 2;

		// Token: 0x040054FA RID: 21754
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040054FB RID: 21755
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040054FC RID: 21756
		public const int BaseAvatarIdListFieldNumber = 4;

		// Token: 0x040054FD RID: 21757
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040054FE RID: 21758
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
