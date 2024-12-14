using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F77 RID: 3959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueSyncContextBoardEvent : IMessage<RogueSyncContextBoardEvent>, IMessage, IEquatable<RogueSyncContextBoardEvent>, IDeepCloneable<RogueSyncContextBoardEvent>, IBufferMessage
	{
		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x001D9DB9 File Offset: 0x001D7FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueSyncContextBoardEvent> Parser
		{
			get
			{
				return RogueSyncContextBoardEvent._parser;
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600B05F RID: 45151 RVA: 0x001D9DC0 File Offset: 0x001D7FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueSyncContextBoardEventReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x001D9DD2 File Offset: 0x001D7FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSyncContextBoardEvent.Descriptor;
			}
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x001D9DD9 File Offset: 0x001D7FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSyncContextBoardEvent()
		{
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x001D9DE1 File Offset: 0x001D7FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSyncContextBoardEvent(RogueSyncContextBoardEvent other) : this()
		{
			this.modifierEffectType_ = other.modifierEffectType_;
			this.boardEventId_ = other.boardEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x001D9E12 File Offset: 0x001D8012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSyncContextBoardEvent Clone()
		{
			return new RogueSyncContextBoardEvent(this);
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x001D9E1A File Offset: 0x001D801A
		// (set) Token: 0x0600B065 RID: 45157 RVA: 0x001D9E22 File Offset: 0x001D8022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ModifierEffectType
		{
			get
			{
				return this.modifierEffectType_;
			}
			set
			{
				this.modifierEffectType_ = value;
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600B066 RID: 45158 RVA: 0x001D9E2B File Offset: 0x001D802B
		// (set) Token: 0x0600B067 RID: 45159 RVA: 0x001D9E33 File Offset: 0x001D8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BoardEventId
		{
			get
			{
				return this.boardEventId_;
			}
			set
			{
				this.boardEventId_ = value;
			}
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x001D9E3C File Offset: 0x001D803C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSyncContextBoardEvent);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x001D9E4A File Offset: 0x001D804A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSyncContextBoardEvent other)
		{
			return other != null && (other == this || (this.ModifierEffectType == other.ModifierEffectType && this.BoardEventId == other.BoardEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x001D9E88 File Offset: 0x001D8088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ModifierEffectType != 0U)
			{
				num ^= this.ModifierEffectType.GetHashCode();
			}
			if (this.BoardEventId != 0U)
			{
				num ^= this.BoardEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x001D9EE0 File Offset: 0x001D80E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x001D9EE8 File Offset: 0x001D80E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x001D9EF4 File Offset: 0x001D80F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModifierEffectType != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ModifierEffectType);
			}
			if (this.BoardEventId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BoardEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x001D9F50 File Offset: 0x001D8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ModifierEffectType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ModifierEffectType);
			}
			if (this.BoardEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BoardEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x001D9FA8 File Offset: 0x001D81A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueSyncContextBoardEvent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ModifierEffectType != 0U)
			{
				this.ModifierEffectType = other.ModifierEffectType;
			}
			if (other.BoardEventId != 0U)
			{
				this.BoardEventId = other.BoardEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x001D9FF8 File Offset: 0x001D81F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x001DA004 File Offset: 0x001D8204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoardEventId = input.ReadUInt32();
					}
				}
				else
				{
					this.ModifierEffectType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040047C4 RID: 18372
		private static readonly MessageParser<RogueSyncContextBoardEvent> _parser = new MessageParser<RogueSyncContextBoardEvent>(() => new RogueSyncContextBoardEvent());

		// Token: 0x040047C5 RID: 18373
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C6 RID: 18374
		public const int ModifierEffectTypeFieldNumber = 5;

		// Token: 0x040047C7 RID: 18375
		private uint modifierEffectType_;

		// Token: 0x040047C8 RID: 18376
		public const int BoardEventIdFieldNumber = 11;

		// Token: 0x040047C9 RID: 18377
		private uint boardEventId_;
	}
}
