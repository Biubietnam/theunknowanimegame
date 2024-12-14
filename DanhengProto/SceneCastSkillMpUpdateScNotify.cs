using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001057 RID: 4183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneCastSkillMpUpdateScNotify : IMessage<SceneCastSkillMpUpdateScNotify>, IMessage, IEquatable<SceneCastSkillMpUpdateScNotify>, IDeepCloneable<SceneCastSkillMpUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x001F4A19 File Offset: 0x001F2C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneCastSkillMpUpdateScNotify> Parser
		{
			get
			{
				return SceneCastSkillMpUpdateScNotify._parser;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600BA40 RID: 47680 RVA: 0x001F4A20 File Offset: 0x001F2C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillMpUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600BA41 RID: 47681 RVA: 0x001F4A32 File Offset: 0x001F2C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneCastSkillMpUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x001F4A39 File Offset: 0x001F2C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillMpUpdateScNotify()
		{
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x001F4A41 File Offset: 0x001F2C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillMpUpdateScNotify(SceneCastSkillMpUpdateScNotify other) : this()
		{
			this.castEntityId_ = other.castEntityId_;
			this.mp_ = other.mp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x001F4A72 File Offset: 0x001F2C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillMpUpdateScNotify Clone()
		{
			return new SceneCastSkillMpUpdateScNotify(this);
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x001F4A7A File Offset: 0x001F2C7A
		// (set) Token: 0x0600BA46 RID: 47686 RVA: 0x001F4A82 File Offset: 0x001F2C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CastEntityId
		{
			get
			{
				return this.castEntityId_;
			}
			set
			{
				this.castEntityId_ = value;
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x001F4A8B File Offset: 0x001F2C8B
		// (set) Token: 0x0600BA48 RID: 47688 RVA: 0x001F4A93 File Offset: 0x001F2C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Mp
		{
			get
			{
				return this.mp_;
			}
			set
			{
				this.mp_ = value;
			}
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x001F4A9C File Offset: 0x001F2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneCastSkillMpUpdateScNotify);
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x001F4AAA File Offset: 0x001F2CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneCastSkillMpUpdateScNotify other)
		{
			return other != null && (other == this || (this.CastEntityId == other.CastEntityId && this.Mp == other.Mp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x001F4AE8 File Offset: 0x001F2CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
			}
			if (this.Mp != 0U)
			{
				num ^= this.Mp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA4C RID: 47692 RVA: 0x001F4B40 File Offset: 0x001F2D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA4D RID: 47693 RVA: 0x001F4B48 File Offset: 0x001F2D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA4E RID: 47694 RVA: 0x001F4B54 File Offset: 0x001F2D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CastEntityId);
			}
			if (this.Mp != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Mp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x001F4BAC File Offset: 0x001F2DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
			}
			if (this.Mp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Mp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x001F4C04 File Offset: 0x001F2E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneCastSkillMpUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			if (other.Mp != 0U)
			{
				this.Mp = other.Mp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x001F4C54 File Offset: 0x001F2E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x001F4C60 File Offset: 0x001F2E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Mp = input.ReadUInt32();
					}
				}
				else
				{
					this.CastEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004B8A RID: 19338
		private static readonly MessageParser<SceneCastSkillMpUpdateScNotify> _parser = new MessageParser<SceneCastSkillMpUpdateScNotify>(() => new SceneCastSkillMpUpdateScNotify());

		// Token: 0x04004B8B RID: 19339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B8C RID: 19340
		public const int CastEntityIdFieldNumber = 1;

		// Token: 0x04004B8D RID: 19341
		private uint castEntityId_;

		// Token: 0x04004B8E RID: 19342
		public const int MpFieldNumber = 14;

		// Token: 0x04004B8F RID: 19343
		private uint mp_;
	}
}
