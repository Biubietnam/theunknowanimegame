using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D9 RID: 4569
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTrialActivityCsReq : IMessage<StartTrialActivityCsReq>, IMessage, IEquatable<StartTrialActivityCsReq>, IDeepCloneable<StartTrialActivityCsReq>, IBufferMessage
	{
		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600CC3D RID: 52285 RVA: 0x00224384 File Offset: 0x00222584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTrialActivityCsReq> Parser
		{
			get
			{
				return StartTrialActivityCsReq._parser;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x0022438B File Offset: 0x0022258B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTrialActivityCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600CC3F RID: 52287 RVA: 0x0022439D File Offset: 0x0022259D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTrialActivityCsReq.Descriptor;
			}
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x002243A4 File Offset: 0x002225A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityCsReq()
		{
		}

		// Token: 0x0600CC41 RID: 52289 RVA: 0x002243AC File Offset: 0x002225AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityCsReq(StartTrialActivityCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC42 RID: 52290 RVA: 0x002243D1 File Offset: 0x002225D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrialActivityCsReq Clone()
		{
			return new StartTrialActivityCsReq(this);
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600CC43 RID: 52291 RVA: 0x002243D9 File Offset: 0x002225D9
		// (set) Token: 0x0600CC44 RID: 52292 RVA: 0x002243E1 File Offset: 0x002225E1
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

		// Token: 0x0600CC45 RID: 52293 RVA: 0x002243EA File Offset: 0x002225EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTrialActivityCsReq);
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x002243F8 File Offset: 0x002225F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTrialActivityCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC47 RID: 52295 RVA: 0x00224428 File Offset: 0x00222628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC48 RID: 52296 RVA: 0x00224467 File Offset: 0x00222667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x0022446F File Offset: 0x0022266F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC4A RID: 52298 RVA: 0x00224478 File Offset: 0x00222678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC4B RID: 52299 RVA: 0x002244AC File Offset: 0x002226AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x002244EA File Offset: 0x002226EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTrialActivityCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x0022451B File Offset: 0x0022271B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x00224524 File Offset: 0x00222724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400525F RID: 21087
		private static readonly MessageParser<StartTrialActivityCsReq> _parser = new MessageParser<StartTrialActivityCsReq>(() => new StartTrialActivityCsReq());

		// Token: 0x04005260 RID: 21088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005261 RID: 21089
		public const int StageIdFieldNumber = 4;

		// Token: 0x04005262 RID: 21090
		private uint stageId_;
	}
}
