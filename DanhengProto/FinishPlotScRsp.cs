using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200058D RID: 1421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishPlotScRsp : IMessage<FinishPlotScRsp>, IMessage, IEquatable<FinishPlotScRsp>, IDeepCloneable<FinishPlotScRsp>, IBufferMessage
	{
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x000AD114 File Offset: 0x000AB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishPlotScRsp> Parser
		{
			get
			{
				return FinishPlotScRsp._parser;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x000AD11B File Offset: 0x000AB31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishPlotScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x000AD12D File Offset: 0x000AB32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishPlotScRsp.Descriptor;
			}
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x000AD134 File Offset: 0x000AB334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotScRsp()
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x000AD13C File Offset: 0x000AB33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotScRsp(FinishPlotScRsp other) : this()
		{
			this.hACHMLAHNPC_ = other.hACHMLAHNPC_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x000AD16D File Offset: 0x000AB36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotScRsp Clone()
		{
			return new FinishPlotScRsp(this);
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x000AD175 File Offset: 0x000AB375
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x000AD17D File Offset: 0x000AB37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HACHMLAHNPC
		{
			get
			{
				return this.hACHMLAHNPC_;
			}
			set
			{
				this.hACHMLAHNPC_ = value;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x000AD186 File Offset: 0x000AB386
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x000AD18E File Offset: 0x000AB38E
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

		// Token: 0x06003F74 RID: 16244 RVA: 0x000AD197 File Offset: 0x000AB397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishPlotScRsp);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x000AD1A5 File Offset: 0x000AB3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishPlotScRsp other)
		{
			return other != null && (other == this || (this.HACHMLAHNPC == other.HACHMLAHNPC && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x000AD1E4 File Offset: 0x000AB3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HACHMLAHNPC != 0U)
			{
				num ^= this.HACHMLAHNPC.GetHashCode();
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

		// Token: 0x06003F77 RID: 16247 RVA: 0x000AD23C File Offset: 0x000AB43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x000AD244 File Offset: 0x000AB444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x000AD250 File Offset: 0x000AB450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.HACHMLAHNPC != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.HACHMLAHNPC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x000AD2AC File Offset: 0x000AB4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HACHMLAHNPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HACHMLAHNPC);
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

		// Token: 0x06003F7B RID: 16251 RVA: 0x000AD304 File Offset: 0x000AB504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishPlotScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HACHMLAHNPC != 0U)
			{
				this.HACHMLAHNPC = other.HACHMLAHNPC;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000AD354 File Offset: 0x000AB554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x000AD360 File Offset: 0x000AB560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HACHMLAHNPC = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400193F RID: 6463
		private static readonly MessageParser<FinishPlotScRsp> _parser = new MessageParser<FinishPlotScRsp>(() => new FinishPlotScRsp());

		// Token: 0x04001940 RID: 6464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001941 RID: 6465
		public const int HACHMLAHNPCFieldNumber = 15;

		// Token: 0x04001942 RID: 6466
		private uint hACHMLAHNPC_;

		// Token: 0x04001943 RID: 6467
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001944 RID: 6468
		private uint retcode_;
	}
}
