using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A05 RID: 2565
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveTrialActivityScRsp : IMessage<LeaveTrialActivityScRsp>, IMessage, IEquatable<LeaveTrialActivityScRsp>, IDeepCloneable<LeaveTrialActivityScRsp>, IBufferMessage
	{
		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x060071D6 RID: 29142 RVA: 0x0012EE40 File Offset: 0x0012D040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveTrialActivityScRsp> Parser
		{
			get
			{
				return LeaveTrialActivityScRsp._parser;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x0012EE47 File Offset: 0x0012D047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveTrialActivityScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x0012EE59 File Offset: 0x0012D059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveTrialActivityScRsp.Descriptor;
			}
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x0012EE60 File Offset: 0x0012D060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityScRsp()
		{
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x0012EE68 File Offset: 0x0012D068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityScRsp(LeaveTrialActivityScRsp other) : this()
		{
			this.stageId_ = other.stageId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x0012EE99 File Offset: 0x0012D099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityScRsp Clone()
		{
			return new LeaveTrialActivityScRsp(this);
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x0012EEA1 File Offset: 0x0012D0A1
		// (set) Token: 0x060071DD RID: 29149 RVA: 0x0012EEA9 File Offset: 0x0012D0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x0012EEB2 File Offset: 0x0012D0B2
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x0012EEBA File Offset: 0x0012D0BA
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

		// Token: 0x060071E0 RID: 29152 RVA: 0x0012EEC3 File Offset: 0x0012D0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveTrialActivityScRsp);
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x0012EED1 File Offset: 0x0012D0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveTrialActivityScRsp other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x0012EF10 File Offset: 0x0012D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
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

		// Token: 0x060071E3 RID: 29155 RVA: 0x0012EF68 File Offset: 0x0012D168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x0012EF70 File Offset: 0x0012D170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x0012EF7C File Offset: 0x0012D17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x0012EFD8 File Offset: 0x0012D1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
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

		// Token: 0x060071E7 RID: 29159 RVA: 0x0012F030 File Offset: 0x0012D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveTrialActivityScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x0012F080 File Offset: 0x0012D280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x0012F08C File Offset: 0x0012D28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StageId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002BC1 RID: 11201
		private static readonly MessageParser<LeaveTrialActivityScRsp> _parser = new MessageParser<LeaveTrialActivityScRsp>(() => new LeaveTrialActivityScRsp());

		// Token: 0x04002BC2 RID: 11202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC3 RID: 11203
		public const int StageIdFieldNumber = 9;

		// Token: 0x04002BC4 RID: 11204
		private uint stageId_;

		// Token: 0x04002BC5 RID: 11205
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04002BC6 RID: 11206
		private uint retcode_;
	}
}
