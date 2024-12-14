using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000385 RID: 901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelSaveRaidScNotify : IMessage<DelSaveRaidScNotify>, IMessage, IEquatable<DelSaveRaidScNotify>, IDeepCloneable<DelSaveRaidScNotify>, IBufferMessage
	{
		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x0006F7B4 File Offset: 0x0006D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DelSaveRaidScNotify> Parser
		{
			get
			{
				return DelSaveRaidScNotify._parser;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0006F7BB File Offset: 0x0006D9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DelSaveRaidScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x0006F7CD File Offset: 0x0006D9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DelSaveRaidScNotify.Descriptor;
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0006F7D4 File Offset: 0x0006D9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelSaveRaidScNotify()
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelSaveRaidScNotify(DelSaveRaidScNotify other) : this()
		{
			this.raidId_ = other.raidId_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x0006F80D File Offset: 0x0006DA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelSaveRaidScNotify Clone()
		{
			return new DelSaveRaidScNotify(this);
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0006F815 File Offset: 0x0006DA15
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0006F81D File Offset: 0x0006DA1D
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

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x0006F826 File Offset: 0x0006DA26
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0006F82E File Offset: 0x0006DA2E
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

		// Token: 0x06002817 RID: 10263 RVA: 0x0006F837 File Offset: 0x0006DA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DelSaveRaidScNotify);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0006F845 File Offset: 0x0006DA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DelSaveRaidScNotify other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0006F884 File Offset: 0x0006DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x0006F8DC File Offset: 0x0006DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0006F8E4 File Offset: 0x0006DAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0006F8F0 File Offset: 0x0006DAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0006F94C File Offset: 0x0006DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0006F9A4 File Offset: 0x0006DBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DelSaveRaidScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0006F9F4 File Offset: 0x0006DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0006FA00 File Offset: 0x0006DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RaidId = input.ReadUInt32();
					}
				}
				else
				{
					this.WorldLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400101D RID: 4125
		private static readonly MessageParser<DelSaveRaidScNotify> _parser = new MessageParser<DelSaveRaidScNotify>(() => new DelSaveRaidScNotify());

		// Token: 0x0400101E RID: 4126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400101F RID: 4127
		public const int RaidIdFieldNumber = 15;

		// Token: 0x04001020 RID: 4128
		private uint raidId_;

		// Token: 0x04001021 RID: 4129
		public const int WorldLevelFieldNumber = 2;

		// Token: 0x04001022 RID: 4130
		private uint worldLevel_;
	}
}
