using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001003 RID: 4099
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournRenameArchiveScRsp : IMessage<RogueTournRenameArchiveScRsp>, IMessage, IEquatable<RogueTournRenameArchiveScRsp>, IDeepCloneable<RogueTournRenameArchiveScRsp>, IBufferMessage
	{
		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600B661 RID: 46689 RVA: 0x001E9629 File Offset: 0x001E7829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournRenameArchiveScRsp> Parser
		{
			get
			{
				return RogueTournRenameArchiveScRsp._parser;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600B662 RID: 46690 RVA: 0x001E9630 File Offset: 0x001E7830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournRenameArchiveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600B663 RID: 46691 RVA: 0x001E9642 File Offset: 0x001E7842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournRenameArchiveScRsp.Descriptor;
			}
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x001E9649 File Offset: 0x001E7849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveScRsp()
		{
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x001E965C File Offset: 0x001E785C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveScRsp(RogueTournRenameArchiveScRsp other) : this()
		{
			this.name_ = other.name_;
			this.retcode_ = other.retcode_;
			this.maxTimes_ = other.maxTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x001E9699 File Offset: 0x001E7899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveScRsp Clone()
		{
			return new RogueTournRenameArchiveScRsp(this);
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600B667 RID: 46695 RVA: 0x001E96A1 File Offset: 0x001E78A1
		// (set) Token: 0x0600B668 RID: 46696 RVA: 0x001E96A9 File Offset: 0x001E78A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600B669 RID: 46697 RVA: 0x001E96BC File Offset: 0x001E78BC
		// (set) Token: 0x0600B66A RID: 46698 RVA: 0x001E96C4 File Offset: 0x001E78C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600B66B RID: 46699 RVA: 0x001E96CD File Offset: 0x001E78CD
		// (set) Token: 0x0600B66C RID: 46700 RVA: 0x001E96D5 File Offset: 0x001E78D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x001E96DE File Offset: 0x001E78DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournRenameArchiveScRsp);
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x001E96EC File Offset: 0x001E78EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournRenameArchiveScRsp other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Retcode == other.Retcode && this.MaxTimes == other.MaxTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x001E974C File Offset: 0x001E794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x001E97BF File Offset: 0x001E79BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x001E97C7 File Offset: 0x001E79C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x001E97D0 File Offset: 0x001E79D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x001E984C File Offset: 0x001E7A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x001E98C0 File Offset: 0x001E7AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournRenameArchiveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x001E9929 File Offset: 0x001E7B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x001E9934 File Offset: 0x001E7B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040049E9 RID: 18921
		private static readonly MessageParser<RogueTournRenameArchiveScRsp> _parser = new MessageParser<RogueTournRenameArchiveScRsp>(() => new RogueTournRenameArchiveScRsp());

		// Token: 0x040049EA RID: 18922
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049EB RID: 18923
		public const int NameFieldNumber = 14;

		// Token: 0x040049EC RID: 18924
		private string name_ = "";

		// Token: 0x040049ED RID: 18925
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040049EE RID: 18926
		private uint retcode_;

		// Token: 0x040049EF RID: 18927
		public const int MaxTimesFieldNumber = 4;

		// Token: 0x040049F0 RID: 18928
		private uint maxTimes_;
	}
}
