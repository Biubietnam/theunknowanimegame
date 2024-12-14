using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200122B RID: 4651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingExamResultConfirmScRsp : IMessage<SwordTrainingExamResultConfirmScRsp>, IMessage, IEquatable<SwordTrainingExamResultConfirmScRsp>, IDeepCloneable<SwordTrainingExamResultConfirmScRsp>, IBufferMessage
	{
		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600CFC3 RID: 53187 RVA: 0x0022C9F9 File Offset: 0x0022ABF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingExamResultConfirmScRsp> Parser
		{
			get
			{
				return SwordTrainingExamResultConfirmScRsp._parser;
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600CFC4 RID: 53188 RVA: 0x0022CA00 File Offset: 0x0022AC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingExamResultConfirmScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x0022CA12 File Offset: 0x0022AC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingExamResultConfirmScRsp.Descriptor;
			}
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x0022CA19 File Offset: 0x0022AC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmScRsp()
		{
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x0022CA21 File Offset: 0x0022AC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmScRsp(SwordTrainingExamResultConfirmScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFC8 RID: 53192 RVA: 0x0022CA46 File Offset: 0x0022AC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmScRsp Clone()
		{
			return new SwordTrainingExamResultConfirmScRsp(this);
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600CFC9 RID: 53193 RVA: 0x0022CA4E File Offset: 0x0022AC4E
		// (set) Token: 0x0600CFCA RID: 53194 RVA: 0x0022CA56 File Offset: 0x0022AC56
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

		// Token: 0x0600CFCB RID: 53195 RVA: 0x0022CA5F File Offset: 0x0022AC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingExamResultConfirmScRsp);
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x0022CA6D File Offset: 0x0022AC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingExamResultConfirmScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x0022CA9C File Offset: 0x0022AC9C
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

		// Token: 0x0600CFCE RID: 53198 RVA: 0x0022CADB File Offset: 0x0022ACDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CFCF RID: 53199 RVA: 0x0022CAE3 File Offset: 0x0022ACE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x0022CAEC File Offset: 0x0022ACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFD1 RID: 53201 RVA: 0x0022CB20 File Offset: 0x0022AD20
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

		// Token: 0x0600CFD2 RID: 53202 RVA: 0x0022CB5E File Offset: 0x0022AD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingExamResultConfirmScRsp other)
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

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x0022CB8F File Offset: 0x0022AD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x0022CB98 File Offset: 0x0022AD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005390 RID: 21392
		private static readonly MessageParser<SwordTrainingExamResultConfirmScRsp> _parser = new MessageParser<SwordTrainingExamResultConfirmScRsp>(() => new SwordTrainingExamResultConfirmScRsp());

		// Token: 0x04005391 RID: 21393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005392 RID: 21394
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005393 RID: 21395
		private uint retcode_;
	}
}
