using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB5 RID: 2997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerMatch3FinishScNotify : IMessage<MultiplayerMatch3FinishScNotify>, IMessage, IEquatable<MultiplayerMatch3FinishScNotify>, IDeepCloneable<MultiplayerMatch3FinishScNotify>, IBufferMessage
	{
		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x0015DECB File Offset: 0x0015C0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerMatch3FinishScNotify> Parser
		{
			get
			{
				return MultiplayerMatch3FinishScNotify._parser;
			}
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06008498 RID: 33944 RVA: 0x0015DED2 File Offset: 0x0015C0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerMatch3FinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06008499 RID: 33945 RVA: 0x0015DEE4 File Offset: 0x0015C0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerMatch3FinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x0015DEEB File Offset: 0x0015C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerMatch3FinishScNotify()
		{
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x0015DEF4 File Offset: 0x0015C0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerMatch3FinishScNotify(MultiplayerMatch3FinishScNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.gDLOCKKLLIK_ = other.gDLOCKKLLIK_;
			this.iMKELKMHOIK_ = ((other.iMKELKMHOIK_ != null) ? other.iMKELKMHOIK_.Clone() : null);
			this.gBGHPFLHDBP_ = other.gBGHPFLHDBP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x0015DF58 File Offset: 0x0015C158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerMatch3FinishScNotify Clone()
		{
			return new MultiplayerMatch3FinishScNotify(this);
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x0600849D RID: 33949 RVA: 0x0015DF60 File Offset: 0x0015C160
		// (set) Token: 0x0600849E RID: 33950 RVA: 0x0015DF68 File Offset: 0x0015C168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Match3FinishReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x0600849F RID: 33951 RVA: 0x0015DF71 File Offset: 0x0015C171
		// (set) Token: 0x060084A0 RID: 33952 RVA: 0x0015DF79 File Offset: 0x0015C179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDLOCKKLLIK
		{
			get
			{
				return this.gDLOCKKLLIK_;
			}
			set
			{
				this.gDLOCKKLLIK_ = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x0015DF82 File Offset: 0x0015C182
		// (set) Token: 0x060084A2 RID: 33954 RVA: 0x0015DF8A File Offset: 0x0015C18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHPIFKICOPP IMKELKMHOIK
		{
			get
			{
				return this.iMKELKMHOIK_;
			}
			set
			{
				this.iMKELKMHOIK_ = value;
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x0015DF93 File Offset: 0x0015C193
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x0015DF9B File Offset: 0x0015C19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GBGHPFLHDBP
		{
			get
			{
				return this.gBGHPFLHDBP_;
			}
			set
			{
				this.gBGHPFLHDBP_ = value;
			}
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x0015DFA4 File Offset: 0x0015C1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerMatch3FinishScNotify);
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x0015DFB4 File Offset: 0x0015C1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerMatch3FinishScNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.GDLOCKKLLIK == other.GDLOCKKLLIK && object.Equals(this.IMKELKMHOIK, other.IMKELKMHOIK) && this.GBGHPFLHDBP == other.GBGHPFLHDBP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x0015E024 File Offset: 0x0015C224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != Match3FinishReason.Default)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.GDLOCKKLLIK != 0U)
			{
				num ^= this.GDLOCKKLLIK.GetHashCode();
			}
			if (this.iMKELKMHOIK_ != null)
			{
				num ^= this.IMKELKMHOIK.GetHashCode();
			}
			if (this.GBGHPFLHDBP != 0U)
			{
				num ^= this.GBGHPFLHDBP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x0015E0B1 File Offset: 0x0015C2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x0015E0B9 File Offset: 0x0015C2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x0015E0C4 File Offset: 0x0015C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != Match3FinishReason.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.GBGHPFLHDBP != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GBGHPFLHDBP);
			}
			if (this.iMKELKMHOIK_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.IMKELKMHOIK);
			}
			if (this.GDLOCKKLLIK != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GDLOCKKLLIK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x0015E154 File Offset: 0x0015C354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != Match3FinishReason.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.GDLOCKKLLIK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDLOCKKLLIK);
			}
			if (this.iMKELKMHOIK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IMKELKMHOIK);
			}
			if (this.GBGHPFLHDBP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GBGHPFLHDBP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x0015E1DC File Offset: 0x0015C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerMatch3FinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != Match3FinishReason.Default)
			{
				this.Reason = other.Reason;
			}
			if (other.GDLOCKKLLIK != 0U)
			{
				this.GDLOCKKLLIK = other.GDLOCKKLLIK;
			}
			if (other.iMKELKMHOIK_ != null)
			{
				if (this.iMKELKMHOIK_ == null)
				{
					this.IMKELKMHOIK = new DHPIFKICOPP();
				}
				this.IMKELKMHOIK.MergeFrom(other.IMKELKMHOIK);
			}
			if (other.GBGHPFLHDBP != 0U)
			{
				this.GBGHPFLHDBP = other.GBGHPFLHDBP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x0015E26C File Offset: 0x0015C46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x0015E278 File Offset: 0x0015C478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Reason = (Match3FinishReason)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.GBGHPFLHDBP = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.iMKELKMHOIK_ == null)
						{
							this.IMKELKMHOIK = new DHPIFKICOPP();
						}
						input.ReadMessage(this.IMKELKMHOIK);
						continue;
					}
					if (num == 72U)
					{
						this.GDLOCKKLLIK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032C0 RID: 12992
		private static readonly MessageParser<MultiplayerMatch3FinishScNotify> _parser = new MessageParser<MultiplayerMatch3FinishScNotify>(() => new MultiplayerMatch3FinishScNotify());

		// Token: 0x040032C1 RID: 12993
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032C2 RID: 12994
		public const int ReasonFieldNumber = 1;

		// Token: 0x040032C3 RID: 12995
		private Match3FinishReason reason_;

		// Token: 0x040032C4 RID: 12996
		public const int GDLOCKKLLIKFieldNumber = 9;

		// Token: 0x040032C5 RID: 12997
		private uint gDLOCKKLLIK_;

		// Token: 0x040032C6 RID: 12998
		public const int IMKELKMHOIKFieldNumber = 8;

		// Token: 0x040032C7 RID: 12999
		private DHPIFKICOPP iMKELKMHOIK_;

		// Token: 0x040032C8 RID: 13000
		public const int GBGHPFLHDBPFieldNumber = 7;

		// Token: 0x040032C9 RID: 13001
		private uint gBGHPFLHDBP_;
	}
}
