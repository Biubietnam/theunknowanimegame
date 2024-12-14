using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDB RID: 3547
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReturnLastTownScRsp : IMessage<ReturnLastTownScRsp>, IMessage, IEquatable<ReturnLastTownScRsp>, IDeepCloneable<ReturnLastTownScRsp>, IBufferMessage
	{
		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x001A7EB5 File Offset: 0x001A60B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReturnLastTownScRsp> Parser
		{
			get
			{
				return ReturnLastTownScRsp._parser;
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x06009E7B RID: 40571 RVA: 0x001A7EBC File Offset: 0x001A60BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReturnLastTownScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x001A7ECE File Offset: 0x001A60CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReturnLastTownScRsp.Descriptor;
			}
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x001A7ED5 File Offset: 0x001A60D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownScRsp()
		{
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x001A7EE0 File Offset: 0x001A60E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownScRsp(ReturnLastTownScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x001A7F2C File Offset: 0x001A612C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownScRsp Clone()
		{
			return new ReturnLastTownScRsp(this);
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x06009E80 RID: 40576 RVA: 0x001A7F34 File Offset: 0x001A6134
		// (set) Token: 0x06009E81 RID: 40577 RVA: 0x001A7F3C File Offset: 0x001A613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x06009E82 RID: 40578 RVA: 0x001A7F45 File Offset: 0x001A6145
		// (set) Token: 0x06009E83 RID: 40579 RVA: 0x001A7F4D File Offset: 0x001A614D
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

		// Token: 0x06009E84 RID: 40580 RVA: 0x001A7F56 File Offset: 0x001A6156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReturnLastTownScRsp);
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x001A7F64 File Offset: 0x001A6164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReturnLastTownScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x001A7FB4 File Offset: 0x001A61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
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

		// Token: 0x06009E87 RID: 40583 RVA: 0x001A8009 File Offset: 0x001A6209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x001A8011 File Offset: 0x001A6211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x001A801C File Offset: 0x001A621C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x001A8078 File Offset: 0x001A6278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
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

		// Token: 0x06009E8B RID: 40587 RVA: 0x001A80D0 File Offset: 0x001A62D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReturnLastTownScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x001A8138 File Offset: 0x001A6338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x001A8144 File Offset: 0x001A6344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004105 RID: 16645
		private static readonly MessageParser<ReturnLastTownScRsp> _parser = new MessageParser<ReturnLastTownScRsp>(() => new ReturnLastTownScRsp());

		// Token: 0x04004106 RID: 16646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004107 RID: 16647
		public const int SceneFieldNumber = 11;

		// Token: 0x04004108 RID: 16648
		private SceneInfo scene_;

		// Token: 0x04004109 RID: 16649
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400410A RID: 16650
		private uint retcode_;
	}
}
