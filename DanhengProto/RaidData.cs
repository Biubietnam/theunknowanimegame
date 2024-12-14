using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6B RID: 3435
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidData : IMessage<RaidData>, IMessage, IEquatable<RaidData>, IDeepCloneable<RaidData>, IBufferMessage
	{
		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600997A RID: 39290 RVA: 0x00198849 File Offset: 0x00196A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidData> Parser
		{
			get
			{
				return RaidData._parser;
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x00198850 File Offset: 0x00196A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600997C RID: 39292 RVA: 0x00198862 File Offset: 0x00196A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidData.Descriptor;
			}
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00198869 File Offset: 0x00196A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidData()
		{
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x0019887C File Offset: 0x00196A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidData(RaidData other) : this()
		{
			this.raidTargetInfo_ = other.raidTargetInfo_.Clone();
			this.worldLevel_ = other.worldLevel_;
			this.raidId_ = other.raidId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x001988C9 File Offset: 0x00196AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidData Clone()
		{
			return new RaidData(this);
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x06009980 RID: 39296 RVA: 0x001988D1 File Offset: 0x00196AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RaidTargetInfo> RaidTargetInfo
		{
			get
			{
				return this.raidTargetInfo_;
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06009981 RID: 39297 RVA: 0x001988D9 File Offset: 0x00196AD9
		// (set) Token: 0x06009982 RID: 39298 RVA: 0x001988E1 File Offset: 0x00196AE1
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

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x001988EA File Offset: 0x00196AEA
		// (set) Token: 0x06009984 RID: 39300 RVA: 0x001988F2 File Offset: 0x00196AF2
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

		// Token: 0x06009985 RID: 39301 RVA: 0x001988FB File Offset: 0x00196AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidData);
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x0019890C File Offset: 0x00196B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidData other)
		{
			return other != null && (other == this || (this.raidTargetInfo_.Equals(other.raidTargetInfo_) && this.WorldLevel == other.WorldLevel && this.RaidId == other.RaidId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x0019896C File Offset: 0x00196B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.raidTargetInfo_.GetHashCode();
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x001989D2 File Offset: 0x00196BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x001989DA File Offset: 0x00196BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x001989E4 File Offset: 0x00196BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RaidId);
			}
			this.raidTargetInfo_.WriteTo(ref output, RaidData._repeated_raidTargetInfo_codec);
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00198A50 File Offset: 0x00196C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.raidTargetInfo_.CalculateSize(RaidData._repeated_raidTargetInfo_codec);
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x00198ABC File Offset: 0x00196CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidData other)
		{
			if (other == null)
			{
				return;
			}
			this.raidTargetInfo_.Add(other.raidTargetInfo_);
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00198B1D File Offset: 0x00196D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00198B28 File Offset: 0x00196D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 42U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WorldLevel = input.ReadUInt32();
						}
					}
					else
					{
						this.raidTargetInfo_.AddEntriesFrom(ref input, RaidData._repeated_raidTargetInfo_codec);
					}
				}
				else
				{
					this.RaidId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B93 RID: 15251
		private static readonly MessageParser<RaidData> _parser = new MessageParser<RaidData>(() => new RaidData());

		// Token: 0x04003B94 RID: 15252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B95 RID: 15253
		public const int RaidTargetInfoFieldNumber = 5;

		// Token: 0x04003B96 RID: 15254
		private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage<RaidTargetInfo>(42U, EggLink.DanhengServer.Proto.RaidTargetInfo.Parser);

		// Token: 0x04003B97 RID: 15255
		private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();

		// Token: 0x04003B98 RID: 15256
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x04003B99 RID: 15257
		private uint worldLevel_;

		// Token: 0x04003B9A RID: 15258
		public const int RaidIdFieldNumber = 2;

		// Token: 0x04003B9B RID: 15259
		private uint raidId_;
	}
}
