using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001151 RID: 4433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShowNewSupplementVisitorScRsp : IMessage<ShowNewSupplementVisitorScRsp>, IMessage, IEquatable<ShowNewSupplementVisitorScRsp>, IDeepCloneable<ShowNewSupplementVisitorScRsp>, IBufferMessage
	{
		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x00212CBC File Offset: 0x00210EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShowNewSupplementVisitorScRsp> Parser
		{
			get
			{
				return ShowNewSupplementVisitorScRsp._parser;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600C5C9 RID: 50633 RVA: 0x00212CC3 File Offset: 0x00210EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShowNewSupplementVisitorScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600C5CA RID: 50634 RVA: 0x00212CD5 File Offset: 0x00210ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowNewSupplementVisitorScRsp.Descriptor;
			}
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x00212CDC File Offset: 0x00210EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorScRsp()
		{
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x00212CE4 File Offset: 0x00210EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorScRsp(ShowNewSupplementVisitorScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x00212D09 File Offset: 0x00210F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorScRsp Clone()
		{
			return new ShowNewSupplementVisitorScRsp(this);
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600C5CE RID: 50638 RVA: 0x00212D11 File Offset: 0x00210F11
		// (set) Token: 0x0600C5CF RID: 50639 RVA: 0x00212D19 File Offset: 0x00210F19
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

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x00212D22 File Offset: 0x00210F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowNewSupplementVisitorScRsp);
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x00212D30 File Offset: 0x00210F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowNewSupplementVisitorScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x00212D60 File Offset: 0x00210F60
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

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x00212D9F File Offset: 0x00210F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x00212DA7 File Offset: 0x00210FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x00212DB0 File Offset: 0x00210FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x00212DE4 File Offset: 0x00210FE4
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

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x00212E22 File Offset: 0x00211022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowNewSupplementVisitorScRsp other)
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

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x00212E53 File Offset: 0x00211053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x00212E5C File Offset: 0x0021105C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004FDF RID: 20447
		private static readonly MessageParser<ShowNewSupplementVisitorScRsp> _parser = new MessageParser<ShowNewSupplementVisitorScRsp>(() => new ShowNewSupplementVisitorScRsp());

		// Token: 0x04004FE0 RID: 20448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FE1 RID: 20449
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004FE2 RID: 20450
		private uint retcode_;
	}
}
