using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000575 RID: 1397
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishedRaidInfo : IMessage<FinishedRaidInfo>, IMessage, IEquatable<FinishedRaidInfo>, IDeepCloneable<FinishedRaidInfo>, IBufferMessage
	{
		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x000AA581 File Offset: 0x000A8781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishedRaidInfo> Parser
		{
			get
			{
				return FinishedRaidInfo._parser;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06003E50 RID: 15952 RVA: 0x000AA588 File Offset: 0x000A8788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishedRaidInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x000AA59A File Offset: 0x000A879A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishedRaidInfo.Descriptor;
			}
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x000AA5A1 File Offset: 0x000A87A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishedRaidInfo()
		{
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x000AA5B4 File Offset: 0x000A87B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishedRaidInfo(FinishedRaidInfo other) : this()
		{
			this.worldLevel_ = other.worldLevel_;
			this.raidId_ = other.raidId_;
			this.aHLPHPEFNIJ_ = other.aHLPHPEFNIJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x000AA601 File Offset: 0x000A8801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishedRaidInfo Clone()
		{
			return new FinishedRaidInfo(this);
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x000AA609 File Offset: 0x000A8809
		// (set) Token: 0x06003E56 RID: 15958 RVA: 0x000AA611 File Offset: 0x000A8811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000AA61A File Offset: 0x000A881A
		// (set) Token: 0x06003E58 RID: 15960 RVA: 0x000AA622 File Offset: 0x000A8822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x000AA62B File Offset: 0x000A882B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AHLPHPEFNIJ
		{
			get
			{
				return this.aHLPHPEFNIJ_;
			}
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x000AA633 File Offset: 0x000A8833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishedRaidInfo);
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x000AA644 File Offset: 0x000A8844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishedRaidInfo other)
		{
			return other != null && (other == this || (this.WorldLevel == other.WorldLevel && this.RaidId == other.RaidId && this.aHLPHPEFNIJ_.Equals(other.aHLPHPEFNIJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			num ^= this.aHLPHPEFNIJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x000AA70A File Offset: 0x000A890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x000AA712 File Offset: 0x000A8912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x000AA71C File Offset: 0x000A891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.RaidId);
			}
			this.aHLPHPEFNIJ_.WriteTo(ref output, FinishedRaidInfo._repeated_aHLPHPEFNIJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x000AA788 File Offset: 0x000A8988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			num += this.aHLPHPEFNIJ_.CalculateSize(FinishedRaidInfo._repeated_aHLPHPEFNIJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x000AA7F4 File Offset: 0x000A89F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishedRaidInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this.aHLPHPEFNIJ_.Add(other.aHLPHPEFNIJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x000AA855 File Offset: 0x000A8A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x000AA860 File Offset: 0x000A8A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.aHLPHPEFNIJ_.AddEntriesFrom(ref input, FinishedRaidInfo._repeated_aHLPHPEFNIJ_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040018DE RID: 6366
		private static readonly MessageParser<FinishedRaidInfo> _parser = new MessageParser<FinishedRaidInfo>(() => new FinishedRaidInfo());

		// Token: 0x040018DF RID: 6367
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018E0 RID: 6368
		public const int WorldLevelFieldNumber = 3;

		// Token: 0x040018E1 RID: 6369
		private uint worldLevel_;

		// Token: 0x040018E2 RID: 6370
		public const int RaidIdFieldNumber = 9;

		// Token: 0x040018E3 RID: 6371
		private uint raidId_;

		// Token: 0x040018E4 RID: 6372
		public const int AHLPHPEFNIJFieldNumber = 15;

		// Token: 0x040018E5 RID: 6373
		private static readonly FieldCodec<uint> _repeated_aHLPHPEFNIJ_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x040018E6 RID: 6374
		private readonly RepeatedField<uint> aHLPHPEFNIJ_ = new RepeatedField<uint>();
	}
}
