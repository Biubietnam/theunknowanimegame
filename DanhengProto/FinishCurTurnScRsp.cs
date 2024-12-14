using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000573 RID: 1395
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishCurTurnScRsp : IMessage<FinishCurTurnScRsp>, IMessage, IEquatable<FinishCurTurnScRsp>, IDeepCloneable<FinishCurTurnScRsp>, IBufferMessage
	{
		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x000AA240 File Offset: 0x000A8440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishCurTurnScRsp> Parser
		{
			get
			{
				return FinishCurTurnScRsp._parser;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x000AA247 File Offset: 0x000A8447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishCurTurnScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x000AA259 File Offset: 0x000A8459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishCurTurnScRsp.Descriptor;
			}
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x000AA260 File Offset: 0x000A8460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnScRsp()
		{
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x000AA268 File Offset: 0x000A8468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnScRsp(FinishCurTurnScRsp other) : this()
		{
			this.oHMOJNNNHLA_ = other.oHMOJNNNHLA_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x000AA299 File Offset: 0x000A8499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnScRsp Clone()
		{
			return new FinishCurTurnScRsp(this);
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x000AA2A1 File Offset: 0x000A84A1
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x000AA2A9 File Offset: 0x000A84A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OHMOJNNNHLA
		{
			get
			{
				return this.oHMOJNNNHLA_;
			}
			set
			{
				this.oHMOJNNNHLA_ = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000AA2B2 File Offset: 0x000A84B2
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x000AA2BA File Offset: 0x000A84BA
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x000AA2C3 File Offset: 0x000A84C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishCurTurnScRsp);
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x000AA2D1 File Offset: 0x000A84D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishCurTurnScRsp other)
		{
			return other != null && (other == this || (this.OHMOJNNNHLA == other.OHMOJNNNHLA && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x000AA310 File Offset: 0x000A8510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OHMOJNNNHLA != 0U)
			{
				num ^= this.OHMOJNNNHLA.GetHashCode();
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

		// Token: 0x06003E45 RID: 15941 RVA: 0x000AA368 File Offset: 0x000A8568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x000AA370 File Offset: 0x000A8570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x000AA37C File Offset: 0x000A857C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OHMOJNNNHLA != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OHMOJNNNHLA);
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x000AA3D8 File Offset: 0x000A85D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OHMOJNNNHLA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OHMOJNNNHLA);
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

		// Token: 0x06003E49 RID: 15945 RVA: 0x000AA430 File Offset: 0x000A8630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishCurTurnScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OHMOJNNNHLA != 0U)
			{
				this.OHMOJNNNHLA = other.OHMOJNNNHLA;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x000AA480 File Offset: 0x000A8680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x000AA48C File Offset: 0x000A868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
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
					this.OHMOJNNNHLA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018D7 RID: 6359
		private static readonly MessageParser<FinishCurTurnScRsp> _parser = new MessageParser<FinishCurTurnScRsp>(() => new FinishCurTurnScRsp());

		// Token: 0x040018D8 RID: 6360
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018D9 RID: 6361
		public const int OHMOJNNNHLAFieldNumber = 8;

		// Token: 0x040018DA RID: 6362
		private uint oHMOJNNNHLA_;

		// Token: 0x040018DB RID: 6363
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040018DC RID: 6364
		private uint retcode_;
	}
}
