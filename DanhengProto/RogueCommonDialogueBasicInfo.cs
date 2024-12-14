using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E41 RID: 3649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueBasicInfo : IMessage<RogueCommonDialogueBasicInfo>, IMessage, IEquatable<RogueCommonDialogueBasicInfo>, IDeepCloneable<RogueCommonDialogueBasicInfo>, IBufferMessage
	{
		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x001B5BC5 File Offset: 0x001B3DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueBasicInfo> Parser
		{
			get
			{
				return RogueCommonDialogueBasicInfo._parser;
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x001B5BCC File Offset: 0x001B3DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueBasicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x001B5BDE File Offset: 0x001B3DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueBasicInfo.Descriptor;
			}
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x001B5BE5 File Offset: 0x001B3DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueBasicInfo()
		{
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x001B5BED File Offset: 0x001B3DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueBasicInfo(RogueCommonDialogueBasicInfo other) : this()
		{
			this.talkDialogueId_ = other.talkDialogueId_;
			this.aeonTalkId_ = other.aeonTalkId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x001B5C1E File Offset: 0x001B3E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueBasicInfo Clone()
		{
			return new RogueCommonDialogueBasicInfo(this);
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x001B5C26 File Offset: 0x001B3E26
		// (set) Token: 0x0600A2C5 RID: 41669 RVA: 0x001B5C2E File Offset: 0x001B3E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalkDialogueId
		{
			get
			{
				return this.talkDialogueId_;
			}
			set
			{
				this.talkDialogueId_ = value;
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600A2C6 RID: 41670 RVA: 0x001B5C37 File Offset: 0x001B3E37
		// (set) Token: 0x0600A2C7 RID: 41671 RVA: 0x001B5C3F File Offset: 0x001B3E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonTalkId
		{
			get
			{
				return this.aeonTalkId_;
			}
			set
			{
				this.aeonTalkId_ = value;
			}
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x001B5C48 File Offset: 0x001B3E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueBasicInfo);
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x001B5C56 File Offset: 0x001B3E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueBasicInfo other)
		{
			return other != null && (other == this || (this.TalkDialogueId == other.TalkDialogueId && this.AeonTalkId == other.AeonTalkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x001B5C94 File Offset: 0x001B3E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkDialogueId != 0U)
			{
				num ^= this.TalkDialogueId.GetHashCode();
			}
			if (this.AeonTalkId != 0U)
			{
				num ^= this.AeonTalkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x001B5CEC File Offset: 0x001B3EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x001B5CF4 File Offset: 0x001B3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x001B5D00 File Offset: 0x001B3F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AeonTalkId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AeonTalkId);
			}
			if (this.TalkDialogueId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TalkDialogueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x001B5D5C File Offset: 0x001B3F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkDialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkDialogueId);
			}
			if (this.AeonTalkId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonTalkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x001B5DB4 File Offset: 0x001B3FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueBasicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkDialogueId != 0U)
			{
				this.TalkDialogueId = other.TalkDialogueId;
			}
			if (other.AeonTalkId != 0U)
			{
				this.AeonTalkId = other.AeonTalkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x001B5E04 File Offset: 0x001B4004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x001B5E10 File Offset: 0x001B4010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TalkDialogueId = input.ReadUInt32();
					}
				}
				else
				{
					this.AeonTalkId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040042AC RID: 17068
		private static readonly MessageParser<RogueCommonDialogueBasicInfo> _parser = new MessageParser<RogueCommonDialogueBasicInfo>(() => new RogueCommonDialogueBasicInfo());

		// Token: 0x040042AD RID: 17069
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042AE RID: 17070
		public const int TalkDialogueIdFieldNumber = 7;

		// Token: 0x040042AF RID: 17071
		private uint talkDialogueId_;

		// Token: 0x040042B0 RID: 17072
		public const int AeonTalkIdFieldNumber = 5;

		// Token: 0x040042B1 RID: 17073
		private uint aeonTalkId_;
	}
}
