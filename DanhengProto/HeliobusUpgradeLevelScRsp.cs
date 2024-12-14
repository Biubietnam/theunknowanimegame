using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E1 RID: 2273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusUpgradeLevelScRsp : IMessage<HeliobusUpgradeLevelScRsp>, IMessage, IEquatable<HeliobusUpgradeLevelScRsp>, IDeepCloneable<HeliobusUpgradeLevelScRsp>, IBufferMessage
	{
		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x0600655A RID: 25946 RVA: 0x0010F054 File Offset: 0x0010D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusUpgradeLevelScRsp> Parser
		{
			get
			{
				return HeliobusUpgradeLevelScRsp._parser;
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x0010F05B File Offset: 0x0010D25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusUpgradeLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x0010F06D File Offset: 0x0010D26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusUpgradeLevelScRsp.Descriptor;
			}
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x0010F074 File Offset: 0x0010D274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelScRsp()
		{
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x0010F07C File Offset: 0x0010D27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelScRsp(HeliobusUpgradeLevelScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x0010F0AD File Offset: 0x0010D2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelScRsp Clone()
		{
			return new HeliobusUpgradeLevelScRsp(this);
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x0010F0B5 File Offset: 0x0010D2B5
		// (set) Token: 0x06006561 RID: 25953 RVA: 0x0010F0BD File Offset: 0x0010D2BD
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

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x0010F0C6 File Offset: 0x0010D2C6
		// (set) Token: 0x06006563 RID: 25955 RVA: 0x0010F0CE File Offset: 0x0010D2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x0010F0D7 File Offset: 0x0010D2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusUpgradeLevelScRsp);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0010F0E5 File Offset: 0x0010D2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusUpgradeLevelScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0010F124 File Offset: 0x0010D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x0010F17C File Offset: 0x0010D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x0010F184 File Offset: 0x0010D384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x0010F190 File Offset: 0x0010D390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x0010F1EC File Offset: 0x0010D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0010F244 File Offset: 0x0010D444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusUpgradeLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x0010F294 File Offset: 0x0010D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x0010F2A0 File Offset: 0x0010D4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 80U)
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
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026FB RID: 9979
		private static readonly MessageParser<HeliobusUpgradeLevelScRsp> _parser = new MessageParser<HeliobusUpgradeLevelScRsp>(() => new HeliobusUpgradeLevelScRsp());

		// Token: 0x040026FC RID: 9980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026FD RID: 9981
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040026FE RID: 9982
		private uint retcode_;

		// Token: 0x040026FF RID: 9983
		public const int LevelFieldNumber = 3;

		// Token: 0x04002700 RID: 9984
		private uint level_;
	}
}
