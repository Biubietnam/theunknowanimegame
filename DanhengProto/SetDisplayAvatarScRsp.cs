using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010EB RID: 4331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetDisplayAvatarScRsp : IMessage<SetDisplayAvatarScRsp>, IMessage, IEquatable<SetDisplayAvatarScRsp>, IDeepCloneable<SetDisplayAvatarScRsp>, IBufferMessage
	{
		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600C118 RID: 49432 RVA: 0x002072EF File Offset: 0x002054EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetDisplayAvatarScRsp> Parser
		{
			get
			{
				return SetDisplayAvatarScRsp._parser;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x002072F6 File Offset: 0x002054F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetDisplayAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600C11A RID: 49434 RVA: 0x00207308 File Offset: 0x00205508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetDisplayAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x0020730F File Offset: 0x0020550F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarScRsp()
		{
		}

		// Token: 0x0600C11C RID: 49436 RVA: 0x00207322 File Offset: 0x00205522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarScRsp(SetDisplayAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.displayAvatarList_ = other.displayAvatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C11D RID: 49437 RVA: 0x00207358 File Offset: 0x00205558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarScRsp Clone()
		{
			return new SetDisplayAvatarScRsp(this);
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600C11E RID: 49438 RVA: 0x00207360 File Offset: 0x00205560
		// (set) Token: 0x0600C11F RID: 49439 RVA: 0x00207368 File Offset: 0x00205568
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

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600C120 RID: 49440 RVA: 0x00207371 File Offset: 0x00205571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarData> DisplayAvatarList
		{
			get
			{
				return this.displayAvatarList_;
			}
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x00207379 File Offset: 0x00205579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetDisplayAvatarScRsp);
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x00207388 File Offset: 0x00205588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetDisplayAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.displayAvatarList_.Equals(other.displayAvatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x002073D8 File Offset: 0x002055D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.displayAvatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C124 RID: 49444 RVA: 0x00207425 File Offset: 0x00205625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C125 RID: 49445 RVA: 0x0020742D File Offset: 0x0020562D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C126 RID: 49446 RVA: 0x00207438 File Offset: 0x00205638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			this.displayAvatarList_.WriteTo(ref output, SetDisplayAvatarScRsp._repeated_displayAvatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x00207488 File Offset: 0x00205688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.displayAvatarList_.CalculateSize(SetDisplayAvatarScRsp._repeated_displayAvatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C128 RID: 49448 RVA: 0x002074DC File Offset: 0x002056DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetDisplayAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.displayAvatarList_.Add(other.displayAvatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x00207529 File Offset: 0x00205729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x00207534 File Offset: 0x00205734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.displayAvatarList_.AddEntriesFrom(ref input, SetDisplayAvatarScRsp._repeated_displayAvatarList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E39 RID: 20025
		private static readonly MessageParser<SetDisplayAvatarScRsp> _parser = new MessageParser<SetDisplayAvatarScRsp>(() => new SetDisplayAvatarScRsp());

		// Token: 0x04004E3A RID: 20026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E3B RID: 20027
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04004E3C RID: 20028
		private uint retcode_;

		// Token: 0x04004E3D RID: 20029
		public const int DisplayAvatarListFieldNumber = 13;

		// Token: 0x04004E3E RID: 20030
		private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage<DisplayAvatarData>(106U, DisplayAvatarData.Parser);

		// Token: 0x04004E3F RID: 20031
		private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();
	}
}
