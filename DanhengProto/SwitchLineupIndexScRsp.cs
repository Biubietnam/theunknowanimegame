using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200121B RID: 4635
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwitchLineupIndexScRsp : IMessage<SwitchLineupIndexScRsp>, IMessage, IEquatable<SwitchLineupIndexScRsp>, IDeepCloneable<SwitchLineupIndexScRsp>, IBufferMessage
	{
		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600CF2B RID: 53035 RVA: 0x0022B668 File Offset: 0x00229868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwitchLineupIndexScRsp> Parser
		{
			get
			{
				return SwitchLineupIndexScRsp._parser;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x0022B66F File Offset: 0x0022986F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwitchLineupIndexScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600CF2D RID: 53037 RVA: 0x0022B681 File Offset: 0x00229881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLineupIndexScRsp.Descriptor;
			}
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x0022B688 File Offset: 0x00229888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexScRsp()
		{
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x0022B690 File Offset: 0x00229890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexScRsp(SwitchLineupIndexScRsp other) : this()
		{
			this.index_ = other.index_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x0022B6C1 File Offset: 0x002298C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLineupIndexScRsp Clone()
		{
			return new SwitchLineupIndexScRsp(this);
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600CF31 RID: 53041 RVA: 0x0022B6C9 File Offset: 0x002298C9
		// (set) Token: 0x0600CF32 RID: 53042 RVA: 0x0022B6D1 File Offset: 0x002298D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600CF33 RID: 53043 RVA: 0x0022B6DA File Offset: 0x002298DA
		// (set) Token: 0x0600CF34 RID: 53044 RVA: 0x0022B6E2 File Offset: 0x002298E2
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

		// Token: 0x0600CF35 RID: 53045 RVA: 0x0022B6EB File Offset: 0x002298EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLineupIndexScRsp);
		}

		// Token: 0x0600CF36 RID: 53046 RVA: 0x0022B6F9 File Offset: 0x002298F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLineupIndexScRsp other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x0022B738 File Offset: 0x00229938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
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

		// Token: 0x0600CF38 RID: 53048 RVA: 0x0022B790 File Offset: 0x00229990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x0022B798 File Offset: 0x00229998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x0022B7A4 File Offset: 0x002299A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Index);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x0022B800 File Offset: 0x00229A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
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

		// Token: 0x0600CF3C RID: 53052 RVA: 0x0022B858 File Offset: 0x00229A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLineupIndexScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x0022B8A8 File Offset: 0x00229AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x0022B8B4 File Offset: 0x00229AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
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
					this.Index = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005361 RID: 21345
		private static readonly MessageParser<SwitchLineupIndexScRsp> _parser = new MessageParser<SwitchLineupIndexScRsp>(() => new SwitchLineupIndexScRsp());

		// Token: 0x04005362 RID: 21346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005363 RID: 21347
		public const int IndexFieldNumber = 3;

		// Token: 0x04005364 RID: 21348
		private uint index_;

		// Token: 0x04005365 RID: 21349
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04005366 RID: 21350
		private uint retcode_;
	}
}
