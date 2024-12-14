using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E9 RID: 5097
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdatePlayerSettingScRsp : IMessage<UpdatePlayerSettingScRsp>, IMessage, IEquatable<UpdatePlayerSettingScRsp>, IDeepCloneable<UpdatePlayerSettingScRsp>, IBufferMessage
	{
		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x0600E33D RID: 58173 RVA: 0x0025C689 File Offset: 0x0025A889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdatePlayerSettingScRsp> Parser
		{
			get
			{
				return UpdatePlayerSettingScRsp._parser;
			}
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x0600E33E RID: 58174 RVA: 0x0025C690 File Offset: 0x0025A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdatePlayerSettingScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x0025C6A2 File Offset: 0x0025A8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerSettingScRsp.Descriptor;
			}
		}

		// Token: 0x0600E340 RID: 58176 RVA: 0x0025C6A9 File Offset: 0x0025A8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingScRsp()
		{
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x0025C6B4 File Offset: 0x0025A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingScRsp(UpdatePlayerSettingScRsp other) : this()
		{
			this.bEMBICIIHNK_ = ((other.bEMBICIIHNK_ != null) ? other.bEMBICIIHNK_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E342 RID: 58178 RVA: 0x0025C700 File Offset: 0x0025A900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSettingScRsp Clone()
		{
			return new UpdatePlayerSettingScRsp(this);
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0600E343 RID: 58179 RVA: 0x0025C708 File Offset: 0x0025A908
		// (set) Token: 0x0600E344 RID: 58180 RVA: 0x0025C710 File Offset: 0x0025A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBONHLAFBFD BEMBICIIHNK
		{
			get
			{
				return this.bEMBICIIHNK_;
			}
			set
			{
				this.bEMBICIIHNK_ = value;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x0025C719 File Offset: 0x0025A919
		// (set) Token: 0x0600E346 RID: 58182 RVA: 0x0025C721 File Offset: 0x0025A921
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

		// Token: 0x0600E347 RID: 58183 RVA: 0x0025C72A File Offset: 0x0025A92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerSettingScRsp);
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x0025C738 File Offset: 0x0025A938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerSettingScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BEMBICIIHNK, other.BEMBICIIHNK) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E349 RID: 58185 RVA: 0x0025C788 File Offset: 0x0025A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEMBICIIHNK_ != null)
			{
				num ^= this.BEMBICIIHNK.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x0025C7DD File Offset: 0x0025A9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x0025C7E5 File Offset: 0x0025A9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x0025C7F0 File Offset: 0x0025A9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.bEMBICIIHNK_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BEMBICIIHNK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x0025C84C File Offset: 0x0025AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEMBICIIHNK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEMBICIIHNK);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x0025C8A4 File Offset: 0x0025AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerSettingScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEMBICIIHNK_ != null)
			{
				if (this.bEMBICIIHNK_ == null)
				{
					this.BEMBICIIHNK = new OBONHLAFBFD();
				}
				this.BEMBICIIHNK.MergeFrom(other.BEMBICIIHNK);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x0025C90C File Offset: 0x0025AB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x0025C918 File Offset: 0x0025AB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.bEMBICIIHNK_ == null)
						{
							this.BEMBICIIHNK = new OBONHLAFBFD();
						}
						input.ReadMessage(this.BEMBICIIHNK);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A57 RID: 23127
		private static readonly MessageParser<UpdatePlayerSettingScRsp> _parser = new MessageParser<UpdatePlayerSettingScRsp>(() => new UpdatePlayerSettingScRsp());

		// Token: 0x04005A58 RID: 23128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A59 RID: 23129
		public const int BEMBICIIHNKFieldNumber = 11;

		// Token: 0x04005A5A RID: 23130
		private OBONHLAFBFD bEMBICIIHNK_;

		// Token: 0x04005A5B RID: 23131
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04005A5C RID: 23132
		private uint retcode_;
	}
}
