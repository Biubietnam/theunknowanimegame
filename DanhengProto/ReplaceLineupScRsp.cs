using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DBB RID: 3515
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReplaceLineupScRsp : IMessage<ReplaceLineupScRsp>, IMessage, IEquatable<ReplaceLineupScRsp>, IDeepCloneable<ReplaceLineupScRsp>, IBufferMessage
	{
		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x001A2CD8 File Offset: 0x001A0ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReplaceLineupScRsp> Parser
		{
			get
			{
				return ReplaceLineupScRsp._parser;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x06009D32 RID: 40242 RVA: 0x001A2CDF File Offset: 0x001A0EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReplaceLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x06009D33 RID: 40243 RVA: 0x001A2CF1 File Offset: 0x001A0EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplaceLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x001A2CF8 File Offset: 0x001A0EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupScRsp()
		{
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x001A2D00 File Offset: 0x001A0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupScRsp(ReplaceLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x001A2D25 File Offset: 0x001A0F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupScRsp Clone()
		{
			return new ReplaceLineupScRsp(this);
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x06009D37 RID: 40247 RVA: 0x001A2D2D File Offset: 0x001A0F2D
		// (set) Token: 0x06009D38 RID: 40248 RVA: 0x001A2D35 File Offset: 0x001A0F35
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

		// Token: 0x06009D39 RID: 40249 RVA: 0x001A2D3E File Offset: 0x001A0F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplaceLineupScRsp);
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x001A2D4C File Offset: 0x001A0F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReplaceLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x001A2D7C File Offset: 0x001A0F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009D3C RID: 40252 RVA: 0x001A2DBB File Offset: 0x001A0FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D3D RID: 40253 RVA: 0x001A2DC3 File Offset: 0x001A0FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x001A2DCC File Offset: 0x001A0FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x001A2E00 File Offset: 0x001A1000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009D40 RID: 40256 RVA: 0x001A2E3E File Offset: 0x001A103E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReplaceLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x001A2E6F File Offset: 0x001A106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x001A2E78 File Offset: 0x001A1078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D1F RID: 15647
		private static readonly MessageParser<ReplaceLineupScRsp> _parser = new MessageParser<ReplaceLineupScRsp>(() => new ReplaceLineupScRsp());

		// Token: 0x04003D20 RID: 15648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D21 RID: 15649
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003D22 RID: 15650
		private uint retcode_;
	}
}
