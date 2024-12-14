using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB7 RID: 3255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerDisplaySettings : IMessage<PlayerDisplaySettings>, IMessage, IEquatable<PlayerDisplaySettings>, IDeepCloneable<PlayerDisplaySettings>, IBufferMessage
	{
		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x0017F2F3 File Offset: 0x0017D4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerDisplaySettings> Parser
		{
			get
			{
				return PlayerDisplaySettings._parser;
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060090D9 RID: 37081 RVA: 0x0017F2FA File Offset: 0x0017D4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerDisplaySettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x0017F30C File Offset: 0x0017D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDisplaySettings.Descriptor;
			}
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x0017F313 File Offset: 0x0017D513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDisplaySettings()
		{
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x0017F328 File Offset: 0x0017D528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDisplaySettings(PlayerDisplaySettings other) : this()
		{
			this.aDAPKPJKOJM_ = ((other.aDAPKPJKOJM_ != null) ? other.aDAPKPJKOJM_.Clone() : null);
			this.challengeList_ = other.challengeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x0017F379 File Offset: 0x0017D579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDisplaySettings Clone()
		{
			return new PlayerDisplaySettings(this);
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060090DE RID: 37086 RVA: 0x0017F381 File Offset: 0x0017D581
		// (set) Token: 0x060090DF RID: 37087 RVA: 0x0017F389 File Offset: 0x0017D589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFAMGMKCPLN ADAPKPJKOJM
		{
			get
			{
				return this.aDAPKPJKOJM_;
			}
			set
			{
				this.aDAPKPJKOJM_ = value;
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x060090E0 RID: 37088 RVA: 0x0017F392 File Offset: 0x0017D592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GHHNONNKCKJ> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0017F39A File Offset: 0x0017D59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDisplaySettings);
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x0017F3A8 File Offset: 0x0017D5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDisplaySettings other)
		{
			return other != null && (other == this || (object.Equals(this.ADAPKPJKOJM, other.ADAPKPJKOJM) && this.challengeList_.Equals(other.challengeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090E3 RID: 37091 RVA: 0x0017F3FC File Offset: 0x0017D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aDAPKPJKOJM_ != null)
			{
				num ^= this.ADAPKPJKOJM.GetHashCode();
			}
			num ^= this.challengeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x0017F446 File Offset: 0x0017D646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0017F44E File Offset: 0x0017D64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x0017F458 File Offset: 0x0017D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aDAPKPJKOJM_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ADAPKPJKOJM);
			}
			this.challengeList_.WriteTo(ref output, PlayerDisplaySettings._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0017F4A8 File Offset: 0x0017D6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aDAPKPJKOJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ADAPKPJKOJM);
			}
			num += this.challengeList_.CalculateSize(PlayerDisplaySettings._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x0017F4FC File Offset: 0x0017D6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerDisplaySettings other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aDAPKPJKOJM_ != null)
			{
				if (this.aDAPKPJKOJM_ == null)
				{
					this.ADAPKPJKOJM = new BFAMGMKCPLN();
				}
				this.ADAPKPJKOJM.MergeFrom(other.ADAPKPJKOJM);
			}
			this.challengeList_.Add(other.challengeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x0017F561 File Offset: 0x0017D761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x0017F56C File Offset: 0x0017D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.challengeList_.AddEntriesFrom(ref input, PlayerDisplaySettings._repeated_challengeList_codec);
					}
				}
				else
				{
					if (this.aDAPKPJKOJM_ == null)
					{
						this.ADAPKPJKOJM = new BFAMGMKCPLN();
					}
					input.ReadMessage(this.ADAPKPJKOJM);
				}
			}
		}

		// Token: 0x040037C6 RID: 14278
		private static readonly MessageParser<PlayerDisplaySettings> _parser = new MessageParser<PlayerDisplaySettings>(() => new PlayerDisplaySettings());

		// Token: 0x040037C7 RID: 14279
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C8 RID: 14280
		public const int ADAPKPJKOJMFieldNumber = 11;

		// Token: 0x040037C9 RID: 14281
		private BFAMGMKCPLN aDAPKPJKOJM_;

		// Token: 0x040037CA RID: 14282
		public const int ChallengeListFieldNumber = 13;

		// Token: 0x040037CB RID: 14283
		private static readonly FieldCodec<GHHNONNKCKJ> _repeated_challengeList_codec = FieldCodec.ForMessage<GHHNONNKCKJ>(106U, GHHNONNKCKJ.Parser);

		// Token: 0x040037CC RID: 14284
		private readonly RepeatedField<GHHNONNKCKJ> challengeList_ = new RepeatedField<GHHNONNKCKJ>();
	}
}
