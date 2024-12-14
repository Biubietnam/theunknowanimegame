using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E47 RID: 3655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueOptionBattleResultInfo : IMessage<RogueCommonDialogueOptionBattleResultInfo>, IMessage, IEquatable<RogueCommonDialogueOptionBattleResultInfo>, IDeepCloneable<RogueCommonDialogueOptionBattleResultInfo>, IBufferMessage
	{
		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x001B6B69 File Offset: 0x001B4D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueOptionBattleResultInfo> Parser
		{
			get
			{
				return RogueCommonDialogueOptionBattleResultInfo._parser;
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x001B6B70 File Offset: 0x001B4D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionBattleResultInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600A30E RID: 41742 RVA: 0x001B6B82 File Offset: 0x001B4D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionBattleResultInfo.Descriptor;
			}
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x001B6B89 File Offset: 0x001B4D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionBattleResultInfo()
		{
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x001B6B91 File Offset: 0x001B4D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionBattleResultInfo(RogueCommonDialogueOptionBattleResultInfo other) : this()
		{
			this.battleEventId_ = other.battleEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x001B6BB6 File Offset: 0x001B4DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionBattleResultInfo Clone()
		{
			return new RogueCommonDialogueOptionBattleResultInfo(this);
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600A312 RID: 41746 RVA: 0x001B6BBE File Offset: 0x001B4DBE
		// (set) Token: 0x0600A313 RID: 41747 RVA: 0x001B6BC6 File Offset: 0x001B4DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleEventId
		{
			get
			{
				return this.battleEventId_;
			}
			set
			{
				this.battleEventId_ = value;
			}
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x001B6BCF File Offset: 0x001B4DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueOptionBattleResultInfo);
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x001B6BDD File Offset: 0x001B4DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueOptionBattleResultInfo other)
		{
			return other != null && (other == this || (this.BattleEventId == other.BattleEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x001B6C0C File Offset: 0x001B4E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleEventId != 0U)
			{
				num ^= this.BattleEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x001B6C4B File Offset: 0x001B4E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x001B6C53 File Offset: 0x001B4E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x001B6C5C File Offset: 0x001B4E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleEventId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BattleEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x001B6C90 File Offset: 0x001B4E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x001B6CCE File Offset: 0x001B4ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueOptionBattleResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleEventId != 0U)
			{
				this.BattleEventId = other.BattleEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x001B6CFF File Offset: 0x001B4EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x001B6D08 File Offset: 0x001B4F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BattleEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040042CC RID: 17100
		private static readonly MessageParser<RogueCommonDialogueOptionBattleResultInfo> _parser = new MessageParser<RogueCommonDialogueOptionBattleResultInfo>(() => new RogueCommonDialogueOptionBattleResultInfo());

		// Token: 0x040042CD RID: 17101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042CE RID: 17102
		public const int BattleEventIdFieldNumber = 11;

		// Token: 0x040042CF RID: 17103
		private uint battleEventId_;
	}
}
