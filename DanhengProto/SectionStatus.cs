using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001099 RID: 4249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SectionStatus : IMessage<SectionStatus>, IMessage, IEquatable<SectionStatus>, IDeepCloneable<SectionStatus>, IBufferMessage
	{
		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x001FE74D File Offset: 0x001FC94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SectionStatus> Parser
		{
			get
			{
				return SectionStatus._parser;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600BD65 RID: 48485 RVA: 0x001FE754 File Offset: 0x001FC954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SectionStatusReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x001FE766 File Offset: 0x001FC966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SectionStatus.Descriptor;
			}
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x001FE76D File Offset: 0x001FC96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SectionStatus()
		{
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x001FE775 File Offset: 0x001FC975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SectionStatus(SectionStatus other) : this()
		{
			this.sectionStatus_ = other.sectionStatus_;
			this.sectionId_ = other.sectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x001FE7A6 File Offset: 0x001FC9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SectionStatus Clone()
		{
			return new SectionStatus(this);
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x001FE7AE File Offset: 0x001FC9AE
		// (set) Token: 0x0600BD6B RID: 48491 RVA: 0x001FE7B6 File Offset: 0x001FC9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageSectionStatus SectionStatus_
		{
			get
			{
				return this.sectionStatus_;
			}
			set
			{
				this.sectionStatus_ = value;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x001FE7BF File Offset: 0x001FC9BF
		// (set) Token: 0x0600BD6D RID: 48493 RVA: 0x001FE7C7 File Offset: 0x001FC9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x001FE7D0 File Offset: 0x001FC9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SectionStatus);
		}

		// Token: 0x0600BD6F RID: 48495 RVA: 0x001FE7DE File Offset: 0x001FC9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SectionStatus other)
		{
			return other != null && (other == this || (this.SectionStatus_ == other.SectionStatus_ && this.SectionId == other.SectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x001FE81C File Offset: 0x001FCA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SectionStatus_ != MessageSectionStatus.MessageSectionNone)
			{
				num ^= this.SectionStatus_.GetHashCode();
			}
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x001FE87A File Offset: 0x001FCA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD72 RID: 48498 RVA: 0x001FE882 File Offset: 0x001FCA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x001FE88C File Offset: 0x001FCA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SectionStatus_ != MessageSectionStatus.MessageSectionNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.SectionStatus_);
			}
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x001FE8E8 File Offset: 0x001FCAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SectionStatus_ != MessageSectionStatus.MessageSectionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SectionStatus_);
			}
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x001FE940 File Offset: 0x001FCB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SectionStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SectionStatus_ != MessageSectionStatus.MessageSectionNone)
			{
				this.SectionStatus_ = other.SectionStatus_;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x001FE990 File Offset: 0x001FCB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x001FE99C File Offset: 0x001FCB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SectionId = input.ReadUInt32();
					}
				}
				else
				{
					this.SectionStatus_ = (MessageSectionStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004D07 RID: 19719
		private static readonly MessageParser<SectionStatus> _parser = new MessageParser<SectionStatus>(() => new SectionStatus());

		// Token: 0x04004D08 RID: 19720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D09 RID: 19721
		public const int SectionStatus_FieldNumber = 5;

		// Token: 0x04004D0A RID: 19722
		private MessageSectionStatus sectionStatus_;

		// Token: 0x04004D0B RID: 19723
		public const int SectionIdFieldNumber = 15;

		// Token: 0x04004D0C RID: 19724
		private uint sectionId_;
	}
}
