using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001135 RID: 4405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetSpringRecoverConfigScRsp : IMessage<SetSpringRecoverConfigScRsp>, IMessage, IEquatable<SetSpringRecoverConfigScRsp>, IDeepCloneable<SetSpringRecoverConfigScRsp>, IBufferMessage
	{
		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600C46E RID: 50286 RVA: 0x0020F3BB File Offset: 0x0020D5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetSpringRecoverConfigScRsp> Parser
		{
			get
			{
				return SetSpringRecoverConfigScRsp._parser;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600C46F RID: 50287 RVA: 0x0020F3C2 File Offset: 0x0020D5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetSpringRecoverConfigScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600C470 RID: 50288 RVA: 0x0020F3D4 File Offset: 0x0020D5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetSpringRecoverConfigScRsp.Descriptor;
			}
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x0020F3DB File Offset: 0x0020D5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigScRsp()
		{
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x0020F3E4 File Offset: 0x0020D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigScRsp(SetSpringRecoverConfigScRsp other) : this()
		{
			this.springRecoverConfig_ = ((other.springRecoverConfig_ != null) ? other.springRecoverConfig_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x0020F430 File Offset: 0x0020D630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSpringRecoverConfigScRsp Clone()
		{
			return new SetSpringRecoverConfigScRsp(this);
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600C474 RID: 50292 RVA: 0x0020F438 File Offset: 0x0020D638
		// (set) Token: 0x0600C475 RID: 50293 RVA: 0x0020F440 File Offset: 0x0020D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig SpringRecoverConfig
		{
			get
			{
				return this.springRecoverConfig_;
			}
			set
			{
				this.springRecoverConfig_ = value;
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600C476 RID: 50294 RVA: 0x0020F449 File Offset: 0x0020D649
		// (set) Token: 0x0600C477 RID: 50295 RVA: 0x0020F451 File Offset: 0x0020D651
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

		// Token: 0x0600C478 RID: 50296 RVA: 0x0020F45A File Offset: 0x0020D65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetSpringRecoverConfigScRsp);
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x0020F468 File Offset: 0x0020D668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetSpringRecoverConfigScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.SpringRecoverConfig, other.SpringRecoverConfig) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x0020F4B8 File Offset: 0x0020D6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.springRecoverConfig_ != null)
			{
				num ^= this.SpringRecoverConfig.GetHashCode();
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

		// Token: 0x0600C47B RID: 50299 RVA: 0x0020F50D File Offset: 0x0020D70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x0020F515 File Offset: 0x0020D715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x0020F520 File Offset: 0x0020D720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.springRecoverConfig_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SpringRecoverConfig);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x0020F57C File Offset: 0x0020D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.springRecoverConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpringRecoverConfig);
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

		// Token: 0x0600C47F RID: 50303 RVA: 0x0020F5D4 File Offset: 0x0020D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetSpringRecoverConfigScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.springRecoverConfig_ != null)
			{
				if (this.springRecoverConfig_ == null)
				{
					this.SpringRecoverConfig = new SpringRecoverConfig();
				}
				this.SpringRecoverConfig.MergeFrom(other.SpringRecoverConfig);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x0020F63C File Offset: 0x0020D83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x0020F648 File Offset: 0x0020D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.springRecoverConfig_ == null)
					{
						this.SpringRecoverConfig = new SpringRecoverConfig();
					}
					input.ReadMessage(this.SpringRecoverConfig);
				}
			}
		}

		// Token: 0x04004F5D RID: 20317
		private static readonly MessageParser<SetSpringRecoverConfigScRsp> _parser = new MessageParser<SetSpringRecoverConfigScRsp>(() => new SetSpringRecoverConfigScRsp());

		// Token: 0x04004F5E RID: 20318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F5F RID: 20319
		public const int SpringRecoverConfigFieldNumber = 6;

		// Token: 0x04004F60 RID: 20320
		private SpringRecoverConfig springRecoverConfig_;

		// Token: 0x04004F61 RID: 20321
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04004F62 RID: 20322
		private uint retcode_;
	}
}
