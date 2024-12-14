using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DB RID: 4571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTrialActivityScRsp : IMessage<StartTrialActivityScRsp>, IMessage, IEquatable<StartTrialActivityScRsp>, IDeepCloneable<StartTrialActivityScRsp>, IBufferMessage
	{
		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600CC52 RID: 52306 RVA: 0x002245FC File Offset: 0x002227FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTrialActivityScRsp> Parser
		{
			get
			{
				return StartTrialActivityScRsp._parser;
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600CC53 RID: 52307 RVA: 0x00224603 File Offset: 0x00222803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTrialActivityScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600CC54 RID: 52308 RVA: 0x00224615 File Offset: 0x00222815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTrialActivityScRsp.Descriptor;
			}
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x0022461C File Offset: 0x0022281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityScRsp()
		{
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x00224624 File Offset: 0x00222824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityScRsp(StartTrialActivityScRsp other) : this()
		{
			this.stageId_ = other.stageId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00224655 File Offset: 0x00222855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityScRsp Clone()
		{
			return new StartTrialActivityScRsp(this);
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600CC58 RID: 52312 RVA: 0x0022465D File Offset: 0x0022285D
		// (set) Token: 0x0600CC59 RID: 52313 RVA: 0x00224665 File Offset: 0x00222865
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

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x0022466E File Offset: 0x0022286E
		// (set) Token: 0x0600CC5B RID: 52315 RVA: 0x00224676 File Offset: 0x00222876
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

		// Token: 0x0600CC5C RID: 52316 RVA: 0x0022467F File Offset: 0x0022287F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTrialActivityScRsp);
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x0022468D File Offset: 0x0022288D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTrialActivityScRsp other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC5E RID: 52318 RVA: 0x002246CC File Offset: 0x002228CC
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

		// Token: 0x0600CC5F RID: 52319 RVA: 0x00224724 File Offset: 0x00222924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x0022472C File Offset: 0x0022292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00224738 File Offset: 0x00222938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.StageId);
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

		// Token: 0x0600CC62 RID: 52322 RVA: 0x00224794 File Offset: 0x00222994
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

		// Token: 0x0600CC63 RID: 52323 RVA: 0x002247EC File Offset: 0x002229EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTrialActivityScRsp other)
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

		// Token: 0x0600CC64 RID: 52324 RVA: 0x0022483C File Offset: 0x00222A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x00224848 File Offset: 0x00222A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
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
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005264 RID: 21092
		private static readonly MessageParser<StartTrialActivityScRsp> _parser = new MessageParser<StartTrialActivityScRsp>(() => new StartTrialActivityScRsp());

		// Token: 0x04005265 RID: 21093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005266 RID: 21094
		public const int StageIdFieldNumber = 5;

		// Token: 0x04005267 RID: 21095
		private uint stageId_;

		// Token: 0x04005268 RID: 21096
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005269 RID: 21097
		private uint retcode_;
	}
}
