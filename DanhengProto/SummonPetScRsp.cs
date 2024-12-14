using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200120B RID: 4619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SummonPetScRsp : IMessage<SummonPetScRsp>, IMessage, IEquatable<SummonPetScRsp>, IDeepCloneable<SummonPetScRsp>, IBufferMessage
	{
		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600CE73 RID: 52851 RVA: 0x00229C89 File Offset: 0x00227E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SummonPetScRsp> Parser
		{
			get
			{
				return SummonPetScRsp._parser;
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600CE74 RID: 52852 RVA: 0x00229C90 File Offset: 0x00227E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SummonPetScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600CE75 RID: 52853 RVA: 0x00229CA2 File Offset: 0x00227EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonPetScRsp.Descriptor;
			}
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x00229CA9 File Offset: 0x00227EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetScRsp()
		{
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00229CB1 File Offset: 0x00227EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetScRsp(SummonPetScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.curPetId_ = other.curPetId_;
			this.newPetId_ = other.newPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE78 RID: 52856 RVA: 0x00229CEE File Offset: 0x00227EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetScRsp Clone()
		{
			return new SummonPetScRsp(this);
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600CE79 RID: 52857 RVA: 0x00229CF6 File Offset: 0x00227EF6
		// (set) Token: 0x0600CE7A RID: 52858 RVA: 0x00229CFE File Offset: 0x00227EFE
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

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600CE7B RID: 52859 RVA: 0x00229D07 File Offset: 0x00227F07
		// (set) Token: 0x0600CE7C RID: 52860 RVA: 0x00229D0F File Offset: 0x00227F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPetId
		{
			get
			{
				return this.curPetId_;
			}
			set
			{
				this.curPetId_ = value;
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x00229D18 File Offset: 0x00227F18
		// (set) Token: 0x0600CE7E RID: 52862 RVA: 0x00229D20 File Offset: 0x00227F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NewPetId
		{
			get
			{
				return this.newPetId_;
			}
			set
			{
				this.newPetId_ = value;
			}
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x00229D29 File Offset: 0x00227F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonPetScRsp);
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x00229D38 File Offset: 0x00227F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonPetScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CurPetId == other.CurPetId && this.NewPetId == other.NewPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x00229D94 File Offset: 0x00227F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurPetId != 0U)
			{
				num ^= this.CurPetId.GetHashCode();
			}
			if (this.NewPetId != 0U)
			{
				num ^= this.NewPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE82 RID: 52866 RVA: 0x00229E05 File Offset: 0x00228005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x00229E0D File Offset: 0x0022800D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x00229E18 File Offset: 0x00228018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewPetId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.NewPetId);
			}
			if (this.CurPetId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurPetId);
			}
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

		// Token: 0x0600CE85 RID: 52869 RVA: 0x00229E90 File Offset: 0x00228090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPetId);
			}
			if (this.NewPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NewPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE86 RID: 52870 RVA: 0x00229F00 File Offset: 0x00228100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonPetScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurPetId != 0U)
			{
				this.CurPetId = other.CurPetId;
			}
			if (other.NewPetId != 0U)
			{
				this.NewPetId = other.NewPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x00229F64 File Offset: 0x00228164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x00229F70 File Offset: 0x00228170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 72U)
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
					else
					{
						this.CurPetId = input.ReadUInt32();
					}
				}
				else
				{
					this.NewPetId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005329 RID: 21289
		private static readonly MessageParser<SummonPetScRsp> _parser = new MessageParser<SummonPetScRsp>(() => new SummonPetScRsp());

		// Token: 0x0400532A RID: 21290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400532B RID: 21291
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400532C RID: 21292
		private uint retcode_;

		// Token: 0x0400532D RID: 21293
		public const int CurPetIdFieldNumber = 9;

		// Token: 0x0400532E RID: 21294
		private uint curPetId_;

		// Token: 0x0400532F RID: 21295
		public const int NewPetIdFieldNumber = 7;

		// Token: 0x04005330 RID: 21296
		private uint newPetId_;
	}
}
