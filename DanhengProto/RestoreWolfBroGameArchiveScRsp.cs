using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD3 RID: 3539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RestoreWolfBroGameArchiveScRsp : IMessage<RestoreWolfBroGameArchiveScRsp>, IMessage, IEquatable<RestoreWolfBroGameArchiveScRsp>, IDeepCloneable<RestoreWolfBroGameArchiveScRsp>, IBufferMessage
	{
		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x001A554F File Offset: 0x001A374F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RestoreWolfBroGameArchiveScRsp> Parser
		{
			get
			{
				return RestoreWolfBroGameArchiveScRsp._parser;
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x001A5556 File Offset: 0x001A3756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RestoreWolfBroGameArchiveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x001A5568 File Offset: 0x001A3768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreWolfBroGameArchiveScRsp.Descriptor;
			}
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x001A556F File Offset: 0x001A376F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveScRsp()
		{
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x001A5578 File Offset: 0x001A3778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveScRsp(RestoreWolfBroGameArchiveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x001A55C4 File Offset: 0x001A37C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveScRsp Clone()
		{
			return new RestoreWolfBroGameArchiveScRsp(this);
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x001A55CC File Offset: 0x001A37CC
		// (set) Token: 0x06009E3F RID: 40511 RVA: 0x001A55D4 File Offset: 0x001A37D4
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

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x06009E40 RID: 40512 RVA: 0x001A55DD File Offset: 0x001A37DD
		// (set) Token: 0x06009E41 RID: 40513 RVA: 0x001A55E5 File Offset: 0x001A37E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x001A55EE File Offset: 0x001A37EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreWolfBroGameArchiveScRsp);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x001A55FC File Offset: 0x001A37FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RestoreWolfBroGameArchiveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x001A564C File Offset: 0x001A384C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x001A56A1 File Offset: 0x001A38A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x001A56A9 File Offset: 0x001A38A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x001A56B4 File Offset: 0x001A38B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x001A5710 File Offset: 0x001A3910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x001A5768 File Offset: 0x001A3968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RestoreWolfBroGameArchiveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x001A57D0 File Offset: 0x001A39D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x001A57DC File Offset: 0x001A39DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 96U)
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
					if (this.wolfBroGameData_ == null)
					{
						this.WolfBroGameData = new WolfBroGameData();
					}
					input.ReadMessage(this.WolfBroGameData);
				}
			}
		}

		// Token: 0x04003D78 RID: 15736
		private static readonly MessageParser<RestoreWolfBroGameArchiveScRsp> _parser = new MessageParser<RestoreWolfBroGameArchiveScRsp>(() => new RestoreWolfBroGameArchiveScRsp());

		// Token: 0x04003D79 RID: 15737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7A RID: 15738
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04003D7B RID: 15739
		private uint retcode_;

		// Token: 0x04003D7C RID: 15740
		public const int WolfBroGameDataFieldNumber = 10;

		// Token: 0x04003D7D RID: 15741
		private WolfBroGameData wolfBroGameData_;
	}
}
